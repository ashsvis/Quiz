using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuizHelper.QuizesUC;

namespace QuizHelper
{
    public partial class AnswerUC : UserControl
    {
        public AnswerUC()
        {
            InitializeComponent();
        }

        public event TournamentTitleChangedEventHandler? TournamentTitleChanged;
        public event TourTitleChangedEventHandler? TourTitleChanged;
        public event TourEditorsChangedEventHandler? TourEditorsChanged;

        private bool busy;

        public void UpdateTable(QuizesUC.Question question, QuizesUC.Tour tour, QuizesUC.Tournament tournament)
        {
            busy = true;
            tbTournament.Text = tournament.title;
            tbTour.Text = tour.title;
            lbQuestionsCount.Text = $"({tour.questions.Count} вопросов)";
            tbEditors.Text = tour.editors;
            tbQuestionNumber.Text = question.number;
            tbQuestion.Text = question.question.Replace("\n", "\r\n");
            tbAnswer.Text = question.answer;
            tbAuthors.Text = question.authors;
            tbSources.Text = question.sources.Replace("\n", "\r\n");
            tbComments.Text = question.comments.Replace("\n", "\r\n");
            busy = false;
        }

        private void tbTour_TextChanged(object sender, EventArgs e)
        {
            if (busy) return;
            tbTour.Tag = true;
        }

        private void tbTour_Validated(object sender, EventArgs e)
        {
            if ((bool?)tbTour.Tag == true)
            {
                TourTitleChanged?.Invoke(this, new TourTitleEventArgs(tbTour.Text));
                tbTour.Tag = null;
            }
        }

        private void tbTournament_TextChanged(object sender, EventArgs e)
        {
            if (busy) return;
            tbTournament.Tag = true;
        }

        private void tbTournament_Validated(object sender, EventArgs e)
        {
            if ((bool?)tbTournament.Tag == true)
            {
                TournamentTitleChanged?.Invoke(this, new TourTitleEventArgs(tbTournament.Text));
                tbTournament.Tag = null;
            }
        }

        private void tbEditors_TextChanged(object sender, EventArgs e)
        {
            if (busy) return;
            tbEditors.Tag = true;
        }

        private void tbEditors_Validated(object sender, EventArgs e)
        {
            if ((bool?)tbEditors.Tag == true)
            {
                TourEditorsChanged?.Invoke(this, new TourEditorsEventArgs(tbEditors.Text));
                tbEditors.Tag = null;
            }
        }
    }

    public class TournamnetTitleEventArgs(string title) : EventArgs
    {
        public string title = title;
    }

    public class TourTitleEventArgs(string title) : EventArgs
    {
        public string title = title;
    }

    public class TourEditorsEventArgs(string editors) : EventArgs
    {
        public string editors = editors;
    }

    public delegate void TournamentTitleChangedEventHandler(object sender, TourTitleEventArgs e);
    public delegate void TourTitleChangedEventHandler(object sender, TourTitleEventArgs e);
    public delegate void TourEditorsChangedEventHandler(object sender, TourEditorsEventArgs e);
}
