
namespace QuizViewer
{
    public class PageQuestionModel : ObservableObject
    {
        private Question? question;
        private string questionText = "Вопрос?";
        private string answerA = "Ответ 1";
        private string answerB = "Ответ 2";
        private string answerC = "Ответ 3";
        private string answerD = "Ответ 4";
        private object? questionImage;
        private int questionNumber;
        private int questionsCount;
        private bool prevQuestionExists = true;
        private bool nextQuestionExists = true;
        private bool answerAexists = true;
        private bool answerBexists = true;
        private bool answerCexists = true;
        private bool answerDexists = true;

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
            get => answerA; 
            set 
            { 
                answerA = value;
                NotifyPropertyChanged();
            }
        }

        public string AnswerB
        {
            get => answerB;
            set
            {
                answerB = value;
                NotifyPropertyChanged();
            }
        }

        public string AnswerC
        {
            get => answerC;
            set
            {
                answerC = value;
                NotifyPropertyChanged();
            }
        }

        public string AnswerD
        {
            get => answerD;
            set
            {
                answerD = value;
                NotifyPropertyChanged();
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
            AnswerA = question.Answer[0];
            AnswerB = question.Answer[1];
            AnswerC = question.Answer[2];
            AnswerD = question.Answer[3];
            PrevQuestionExists = question.PrevQuestion != null;
            NextQuestionExists = question.NextQuestion != null;
            AnswerAexists = !string.IsNullOrEmpty(AnswerA);
            AnswerBexists = !string.IsNullOrEmpty(AnswerB);
            AnswerCexists = !string.IsNullOrEmpty(AnswerC);
            AnswerDexists = !string.IsNullOrEmpty(AnswerD);
        }
    }
}
