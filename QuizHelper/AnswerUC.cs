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
        public event QuestionPictureChangedEventHandler? QuestionPictureChanged;

        private bool busy;

        public void UpdateTable(QuizesUC.Question question, QuizesUC.Tour tour, QuizesUC.Tournament tournament)
        {
            busy = true;
            tbTournament.Text = tournament.title;
            tbTour.Text = tour.title;
            lbQuestionsCount.Text = $"({tour.questions.Count} вопросов)";
            tbEditors.Text = tour.editors;
            tbQuestionNumber.Text = question.number;
            var skipLen = 0;
            if (question.questionImage != null)
            {
                btnAddPicture.Visible = false;
                pbQuestionsPicture.Visible = true;
                pbQuestionsPicture.Image = question.questionImage;
            }
            else if (question.question.StartsWith("(pic: "))
            {
                pbQuestionsPicture.Height = 25;
                var picname = question.question[6..question.question.IndexOf(')')];
                //Image image = new Bitmap(200, 25);
                //using Graphics graphics = Graphics.FromImage(image);
                //using Font font = new("Arial Narrow", 12f, FontStyle.Regular, GraphicsUnit.Pixel);
                //graphics.DrawString(picname, font, Brushes.Gray, Point.Empty);
                //pbQuestionsPicture.Image = image;
                //pbQuestionsPicture.Cursor = Cursors.Hand;
                pbQuestionsPicture.Click += (s, e) =>
                {
                    if (Clipboard.GetDataObject() is DataObject retrievedData && retrievedData.ContainsImage())
                    {
                        var image = retrievedData.GetImage();
                        if (image != null)
                        {
                            question.questionImage = image;
                            pbQuestionsPicture.Image = image;
                            QuestionPictureChanged?.Invoke(this, new QuestionPictureEventArgs(image));
                        }
                    }
                };
                btnAddPicture.Click += (s, e) =>
                {
                    if (Clipboard.GetDataObject() is DataObject retrievedData && retrievedData.ContainsImage())
                    {
                        btnAddPicture.Visible = false;
                        pbQuestionsPicture.Visible = true;
                        var image = retrievedData.GetImage();
                        if (image != null)
                        {
                            question.questionImage = image;
                            pbQuestionsPicture.Image = image;
                            QuestionPictureChanged?.Invoke(this, new QuestionPictureEventArgs(image));
                        }
                    }
                };

                skipLen = picname.Length + 8;
            }
            else
                btnAddPicture.Visible = false;
            tbQuestion.Text = question.question[skipLen..].Replace("\n", " ");
            tbAnswer.Text = question.answer;
            tbAuthors.Text = question.authors;
            tbSources.Text = question.sources.Replace("\n", "\r\n");
            tbComments.Text = question.comments.Replace("\n", " ");
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

    public class QuestionPictureEventArgs(Image image) : EventArgs
    {
        public Image image = image;
    }

    public delegate void TournamentTitleChangedEventHandler(object sender, TourTitleEventArgs e);
    public delegate void TourTitleChangedEventHandler(object sender, TourTitleEventArgs e);
    public delegate void TourEditorsChangedEventHandler(object sender, TourEditorsEventArgs e);
    public delegate void QuestionPictureChangedEventHandler(object sender, QuestionPictureEventArgs e);
}
