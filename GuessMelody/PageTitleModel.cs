
namespace GuessMelody
{
    public class PageTitleModel : ObservableObject
    {
        private string? title;
        private string? question;
        private string? answer;
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

        public string? Question 
        { 
            get => question; 
            set 
            { 
                question = value;
                NotifyPropertyChanged();
            }
        }

        public string? Answer 
        { 
            get => answer; 
            set 
            { 
                answer = value;
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
            Title = slide.Title;
            Image = slide.Image;
        }
    }
}
