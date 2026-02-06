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
    public partial class QuestionsUC : UserControl
    {
        public QuestionsUC()
        {
            InitializeComponent();
        }

        public void UpdateTable(QuizesUC.Tournament tournament)
        {
            lvTable.BeginUpdate();
            lvTable.Items.Clear();
            lvTable.Groups.Clear();
            foreach (var tour in tournament.tours)
            {
                ListViewGroup group = new(tour.title, HorizontalAlignment.Center);
                lvTable.Groups.Add(group);
                foreach (var question in tour.questions.OrderBy(x => int.Parse(x.number)))
                {
                    var lvi = new ListViewItem(group);
                    lvi.SubItems.Add(question.number + ".");
                    lvi.SubItems.Add(question.question.Replace("\n", " "));
                    lvTable.Items.Add(lvi);
                }
            }
            lvTable.EndUpdate();
        }

        public void UpdateTable(QuizesUC.Tour tour)
        {
            lvTable.BeginUpdate();
            lvTable.Items.Clear();
            lvTable.Groups.Clear();
            ListViewGroup group = new(tour.title, HorizontalAlignment.Center);
            lvTable.Groups.Add(group);
            foreach (var question in tour.questions.OrderBy(x => int.Parse(x.number)))
            {
                var lvi = new ListViewItem(group);
                lvi.SubItems.Add(question.number + ".");
                lvi.SubItems.Add(question.question.Replace("\n", " "));
                lvTable.Items.Add(lvi);
            }
            lvTable.EndUpdate();
        }
    }
}
