

namespace QuizViewer
{
    public class Tournament
    {
        public string? Title;
        public int Totaltours;
        public Tour? FirstTour;
        public Question? CurrentQuestion;
        public bool IsWinQuestion;

        public int ExpertsScore = 0;
        public int ViewersScore = 0;

        public static bool GoPrevQuestion()
        {
            if (Root.Tournament.CurrentQuestion == null || Root.Tournament.CurrentQuestion.PrevQuestion == null)
            {
                Root.Tournament.CurrentQuestion = null;
                return false;
            }
            Root.Tournament.CurrentQuestion = Root.Tournament.CurrentQuestion.PrevQuestion;
            return true;
        }

        public static bool GoNextQuestion()
        {
            if (Root.Tournament.CurrentQuestion == null || Root.Tournament.CurrentQuestion.NextQuestion == null)
            {
                Root.Tournament.CurrentQuestion = null;
                return false;
            }
            Root.Tournament.CurrentQuestion = Root.Tournament.CurrentQuestion.NextQuestion;
            return true;
        }

        public static bool IsNextQuestion => Root.Tournament.CurrentQuestion != null && Root.Tournament.CurrentQuestion.PrevQuestion != null;

        public static bool IsFinish => Root.Tournament.CurrentQuestion == null;

        public static bool CheckAnswer(string choose, out string answer)
        {
            answer = "";
            if (Root.Tournament.CurrentQuestion == null) return false;
            bool result = false;
            switch (choose)
            {
                case "A":
                    result = Root.Tournament.CurrentQuestion.Answers[0].IsWin;
                    answer = Root.Tournament.CurrentQuestion.Answers[0].Title;
                    break;
                case "B":
                    result = Root.Tournament.CurrentQuestion.Answers[1].IsWin;
                    answer = Root.Tournament.CurrentQuestion.Answers[1].Title;
                    break;
                case "C":
                    result = Root.Tournament.CurrentQuestion.Answers[2].IsWin;
                    answer = Root.Tournament.CurrentQuestion.Answers[2].Title;
                    break;
                case "D":
                    result = Root.Tournament.CurrentQuestion.Answers[3].IsWin;
                    answer = Root.Tournament.CurrentQuestion.Answers[3].Title;
                    break;
            }
            if (result)
                Root.Tournament.ExpertsScore += 1;
            else
                Root.Tournament.ViewersScore += 1;
            Root.Tournament.IsWinQuestion = result;
            return result;
        }
    }
}
