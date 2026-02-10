
namespace QuizViewer
{
    public class PageQuestionModel : ObservableObject
    {
        private string questionText = "Вопрос?"; //string.Empty;
        private string answerA = "Ответ 1"; //string.Empty;
        private string answerB = "Ответ 2"; //string.Empty;
        private string answerC = "Ответ 3"; //string.Empty;
        private string answerD = "Ответ 4"; //string.Empty;
        private object? questionImage;
        private int questionNumber;
        private int questionsCount;

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

        public void Assign(Question? question)
        {
            if (question == null) return;
            QuestionNumber = question.Number;
            QuestionsCount = question.Total;
            QuestionText = question.Title ?? "";
            AnswerA = question.Answer[0];
            AnswerB = question.Answer[1];
            AnswerC = question.Answer[2];
            AnswerD = question.Answer[3];
        }
    }
}
