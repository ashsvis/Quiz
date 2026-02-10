using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace QuizViewer
{
    /// <summary>
    /// Логика взаимодействия для PageTitle.xaml
    /// </summary>
    public partial class PageTitle : Page
    {
        private readonly Frame mainFrame;

        public PageTitle(Frame mainFrame)
        {
            InitializeComponent();
            this.mainFrame = mainFrame;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //mePlayer.Play();
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            var xdoc = XDocument.Parse(Properties.Resources.tournament);
            XElement? xTournament = xdoc?.Element("Tournament");
            if (xTournament != null)
            {
                Tournament tournament = new() { Title = xTournament.Attribute("Title")?.Value };
                foreach (XElement xTour in xTournament.Elements("Tour"))
                {
                    Tour tour = new() { Title = xTour.Attribute("Title")?.Value };
                    tournament.FirstTour ??= tour;
                    var nquest = 0;
                    Question? question = null;
                    foreach (XElement xQuestion in xTour.Elements("Question"))
                    {
                        Question quest = new()
                        {
                            Title = xQuestion.Element("Title")?.Value,
                            Number = nquest + 1,
                            PrevQuestion = question
                        };
                        if (question != null) 
                            question.NextQuestion = quest;
                        question = quest;
                        nquest++;
                        tour.FirstQuestion ??= quest;
                        var nanswer = 0;
                        foreach (XElement xAnswer in xQuestion.Elements("Answer"))
                        {
                            quest.Answer[nanswer++] = xAnswer.Value;
                            if (nanswer > 3) break;
                        }
                    }
                    tour.TotalQuestions = nquest;
                    question = tour.FirstQuestion;
                    while (question != null)
                    {
                        question.Total = nquest;
                        question = question.NextQuestion;
                    }
                }
                if (tournament.FirstTour is Tour tour1 && tour1.FirstQuestion is Question question1)
                    mainFrame.Navigate(new PageQuestion(mainFrame, question1));
            }
        }
    }
}
