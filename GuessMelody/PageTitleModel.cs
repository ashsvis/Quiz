
namespace GuessMelody
{
    public class PageTitleModel : ObservableObject
    {
        private string? title;
        private string? soundMinus;
        private string? sound;
        private object? image;
        private string? video;

        private bool enabled = true;
        private Slide? Slide;

        public bool Enabled
        {
            get => enabled;
            set
            {
                enabled = value;
                NotifyPropertyChanged();
            }
        }

        public string? Title 
        { 
            get => title; 
            set 
            { 
                title = value;
                NotifyPropertyChanged();
            }
        }

        public string? SoundMinus 
        { 
            get => soundMinus; 
            set 
            { 
                soundMinus = value;
                NotifyPropertyChanged();
            }
        }

        public string? Sound
        { 
            get => sound; 
            set 
            { 
                sound = value;
                NotifyPropertyChanged();
            }
        }

        public object? Image 
        { 
            get => image; 
            set 
            { 
                image = value;
                NotifyPropertyChanged();
            }
        }

        public string? Video 
        { 
            get => video; 
            set 
            { 
                video = value;
                NotifyPropertyChanged();
            }
        }

        public void Assign(Slide? slide)
        {
            if (slide == null) return;
            Slide = slide;
            //Title = slide.Title;
            //Image = slide.Image;
            SoundMinus = slide.Question;
            Sound = slide.Answer;
            Video = slide.Video;
        }
    }
}
