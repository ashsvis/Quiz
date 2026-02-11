namespace QuizViewer
{
    public class Question
    {
        public int Number;
        public int Total;
        public string? Title;
        public object? Image;
        public Answer[] Answers = [new Answer(), new Answer(), new Answer(), new Answer()];
        public int AnswerIndex;
        public Question? PrevQuestion;
        public Question? NextQuestion;
    }
}
