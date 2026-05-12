using System.Speech.Synthesis;

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
        private string? answerA = "Ответ1";
        private string? answerB = "Ответ2";
        private string? answerC = "Ответ3";
        private string? answerD = "Ответ4";
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
            get => answerA ?? "";
            set
            {
                answerA = value;
                NotifyPropertyChanged();
            }
        }

        public string AnswerB
        {
            get => answerB ?? "";
            set
            {
                answerB = value;
                NotifyPropertyChanged();
            }
        }

        public string AnswerC
        {
            get => answerC ?? "";
            set
            {
                answerC = value;
                NotifyPropertyChanged();
            }
        }

        public string AnswerD
        {
            get => answerD ?? "";
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
            Random random = new();
            List<int> items = [];
            UpdateItems(random, items);
            UpdateItems(random, items);
            UpdateItems(random, items);
            UpdateItems(random, items);
            AnswerA = $"{question.Answers[items[0]].Title}";
            AnswerB = $"{question.Answers[items[1]].Title}";
            AnswerC = $"{question.Answers[items[2]].Title}";
            AnswerD = $"{question.Answers[items[3]].Title}";
            question.Answers[0].IsWin = items[0] == 0;
            question.Answers[1].IsWin = items[1] == 0;
            question.Answers[2].IsWin = items[2] == 0;
            question.Answers[3].IsWin = items[3] == 0;
            PrevQuestionExists = question.PrevQuestion != null;
            NextQuestionExists = question.NextQuestion != null;
            AnswerAexists = !string.IsNullOrEmpty(AnswerA);
            AnswerBexists = !string.IsNullOrEmpty(AnswerB);
            AnswerCexists = !string.IsNullOrEmpty(AnswerC);
            AnswerDexists = !string.IsNullOrEmpty(AnswerD);            
        }

        private static void UpdateItems(Random random, List<int> items)
        {
            while (true)
            {
                var index = random.Next(4);
                if (!items.Contains(index))
                {
                    items.Add(index);
                    break;
                }
            }
        }
    }
}
