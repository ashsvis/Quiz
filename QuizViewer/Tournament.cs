

namespace QuizViewer
{
    public class Tournament
    {
        public string? Title;
        public int Totaltours;
        public Tour? FirstTour;
        public Question? CurrentQuestion;
        public int ExpertsScore = 0;
        public int ViewersScore = 0;

        public static bool GoPrevQuestion()
        {
            if (Root.Tournament.CurrentQuestion == null || Root.Tournament.CurrentQuestion.PrevQuestion == null) return false;
            Root.Tournament.CurrentQuestion = Root.Tournament.CurrentQuestion.PrevQuestion;
            return true;
        }

        public static bool GoNextQuestion()
        {
            if (Root.Tournament.CurrentQuestion == null || Root.Tournament.CurrentQuestion.NextQuestion == null) return false;
            Root.Tournament.CurrentQuestion = Root.Tournament.CurrentQuestion.NextQuestion;
            return true;
        }

        public static bool IsNextQuestion => Root.Tournament.CurrentQuestion != null && Root.Tournament.CurrentQuestion.PrevQuestion != null;

        public static bool CheckAnswer(string choose)
        {
            if (Root.Tournament.CurrentQuestion == null) return false;
            bool result = false;
            switch (choose)
            {
                case "A":
                    break;
                case "B":
                    break;
                case "C":
                    break;
                case "D":
                    break;
            }
            if (result)
                Root.Tournament.ExpertsScore += 1;
            else
                Root.Tournament.ViewersScore += 1;
            return result;
        }
    }
}
