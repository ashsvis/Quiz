
namespace QuizViewer
{
    public class PageQuestionModel : ObservableObject
    {
        private Question? question;
        private string questionText = "Вопрос?";
        private object? questionImage;
        private int questionNumber;
        private int questionsCount;
        private bool prevQuestionExists = true;
        private bool nextQuestionExists = true;
        private bool answerAexists = true;
        private bool answerBexists = true;
        private bool answerCexists = true;
        private bool answerDexists = true;

        private bool enabled = true;

        public bool Enabled
        {
            get => enabled; 
            set
            {
                enabled = value;
                NotifyPropertyChanged();
            }
        }

        public int QuestionNumber 
        { 
            get => questionNumber; 
            set 
            { 
                questionNumber = value;
                NotifyPropertyChanged();
            }
        }

        public int QuestionsCount
        {
            get => questionsCount; 
            set 
            { 
                questionsCount = value;
                NotifyPropertyChanged();
            }
        }

        public string QuestionText 
        { 
            get => questionText;
            set
            {
                questionText = value;
                NotifyPropertyChanged();
            }
        }

        public object? QuestionImage 
        { 
            get => questionImage; 
            set 
            {
                questionImage = value;
                NotifyPropertyChanged();
            }
        }

        public string AnswerA
        { 
            get => $"{question?.Answers[0].Title}"; 
            set 
            {
                if (question != null)
                {
                    question.Answers[0].Title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string AnswerB
        {
            get => $"{question?.Answers[1].Title}";
            set
            {
                if (question != null)
                {
                    question.Answers[1].Title = value;
                    NotifyPropertyChanged();
                }
            }
        }
        public string AnswerC
        {
            get => $"{question?.Answers[2].Title}";
            set
            {
                if (question != null)
                {
                    question.Answers[2].Title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string AnswerD
        {
            get => $"{question?.Answers[3].Title}";
            set
            {
                if (question != null)
                {
                    question.Answers[3].Title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public bool PrevQuestionExists 
        { 
            get => prevQuestionExists; 
            set 
            { 
                prevQuestionExists = value;
                NotifyPropertyChanged();
            }
        }

        public bool NextQuestionExists 
        { 
            get => nextQuestionExists; 
            set 
            { 
                nextQuestionExists = value;
                NotifyPropertyChanged();
            }
        }

        public bool AnswerAexists
        {
            get => answerAexists;
            set
            {
                answerAexists = value;
                NotifyPropertyChanged();
            }
        }

        public bool AnswerBexists
        {
            get => answerBexists;
            set
            {
                answerBexists = value;
                NotifyPropertyChanged();
            }
        }

        public bool AnswerCexists
        {
            get => answerCexists;
            set
            {
                answerCexists = value;
                NotifyPropertyChanged();
            }
        }

        public bool AnswerDexists
        {
            get => answerDexists;
            set
            {
                answerDexists = value;
                NotifyPropertyChanged();
            }
        }

        public void Assign(Question? question)
        {
            this.question = question;
            if (question == null) return;
            QuestionNumber = question.Number;
            QuestionsCount = question.Total;
            QuestionText = question.Title ?? "";
            AnswerA = $"{question.Answers[0].Title}";
            AnswerB = $"{question.Answers[1].Title}";
            AnswerC = $"{question.Answers[2].Title}";
            AnswerD = $"{question.Answers[3].Title}";
            PrevQuestionExists = question.PrevQuestion != null;
            NextQuestionExists = question.NextQuestion != null;
            AnswerAexists = !string.IsNullOrEmpty(AnswerA);
            AnswerBexists = !string.IsNullOrEmpty(AnswerB);
            AnswerCexists = !string.IsNullOrEmpty(AnswerC);
            AnswerDexists = !string.IsNullOrEmpty(AnswerD);
        }
    }
}
