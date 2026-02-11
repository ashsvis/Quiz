namespace QuizViewer
{
    public class PageTurnamentModel : ObservableObject
    {
        public static Question? CurrentQuestion => Root.Tournament.CurrentQuestion;
    }
}
