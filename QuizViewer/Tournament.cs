
namespace QuizViewer
{
    public class Tournament
    {
        public string? Title;
        public int Totaltours;
        public Tour? FirstTour;
        public Question? CurrentQuestion;

        public static void GoPrevQuestion()
        {
            if (Root.Tournament.CurrentQuestion == null || Root.Tournament.CurrentQuestion.PrevQuestion == null) return;
            Root.Tournament.CurrentQuestion = Root.Tournament.CurrentQuestion.PrevQuestion;
        }

        public static void GoNextQuestion()
        {
            if (Root.Tournament.CurrentQuestion == null || Root.Tournament.CurrentQuestion.NextQuestion == null) return;
            Root.Tournament.CurrentQuestion = Root.Tournament.CurrentQuestion.NextQuestion;
        }
    }
}
