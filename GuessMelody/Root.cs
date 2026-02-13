using System.IO;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace GuessMelody
{
    public static class Root
    {
        private static Presentation presentation = new();

        public static Presentation Presentation => presentation;

        public static BitmapSource BitmapSourceFromBase64(string value)
        {
            ArgumentNullException.ThrowIfNull(value);

            using var stream = new MemoryStream(Convert.FromBase64String(value));
            var decoder = new PngBitmapDecoder(stream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);
            BitmapSource result = decoder.Frames[0];
            result.Freeze();
            return result;
        }

        public static void Init()
        {
            presentation = new();
            var xdoc = XDocument.Parse(Properties.Resources.content);
            XElement? xPresentation = xdoc?.Element("Presentation");
            if (xPresentation != null)
            {
                presentation = new();
                Slide? slide = null;
                foreach (XElement xSlide in xPresentation.Elements("Slide"))
                {
                    Slide quest = new()
                    {
                        Title = xSlide.Element("Title")?.Value,
                        Question = xSlide.Element("Question")?.Value,
                        Answer = xSlide.Element("Answer")?.Value,
                        Video = xSlide.Element("Video")?.Value,
                        PrevSlide = slide
                    };
                    string? imageSource = xSlide.Element("Image")?.Value;
                    if (!string.IsNullOrEmpty(imageSource))
                    {
                        quest.Image = BitmapSourceFromBase64(imageSource);
                    }
                    if (slide != null)
                        slide.NextSlide = quest;
                    slide = quest;
                    presentation.Slide ??= slide;
                }
            }
        }

        public static bool NextSlide(this Slide slide)
        {
            if (slide.NextSlide == null) return false;
            presentation.Slide = slide.NextSlide;
            return true;
        }
    }
}
