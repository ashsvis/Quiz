using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizHelper
{
    public partial class AnswerUC : UserControl
    {
        public AnswerUC()
        {
            InitializeComponent();
        }

        public void UpdateTable(QuizesUC.Question question, QuizesUC.Tour tour, QuizesUC.Tournament tournament)
        {
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
        }
    }
}
