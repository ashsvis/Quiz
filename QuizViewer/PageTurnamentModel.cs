namespace QuizViewer
{
    public class PageTurnamentModel : ObservableObject
    {
        public static Question? CurrentQuestion => Root.Tournament.CurrentQuestion;
        public static int ExpertsScore => Root.Tournament.ExpertsScore;
        public static int ViewersScore => Root.Tournament.ViewersScore;
    }
}
