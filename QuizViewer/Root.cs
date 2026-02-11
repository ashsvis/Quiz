using System.Xml.Linq;

namespace QuizViewer
{
    public static class Root
    {
        private static Tournament tournament = new();

        public static Tournament Tournament => tournament;

        public static void Init()
        {
            tournament = new();
            var xdoc = XDocument.Parse(Properties.Resources.tournament);
            XElement? xTournament = xdoc?.Element("Tournament");
            if (xTournament != null)
            {
                tournament = new() { Title = xTournament.Attribute("Title")?.Value };
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
                        tournament.CurrentQuestion ??= quest;
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
            }
        }
    }
}
