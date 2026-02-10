namespace QuizViewer
{
    public class Question
    {
        public int Number;
        public int Total;
        public string? Title;
        public object? Image;
        public string[] Answer = ["", "", "", ""];
        public int AnswerIndex;
        public Question? PrevQuestion;
        public Question? NextQuestion;
    }
}
