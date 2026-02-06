using Newtonsoft.Json;
using System.Xml.Linq;

namespace QuizHelper
{
    public partial class QuizesUC : UserControl
    {
        public QuizesUC()
        {
            InitializeComponent();
        }

        private void QuizesUC_Load(object sender, EventArgs e)
        {
            LoadContent();
            timerDataChecker.Enabled = true;
        }

        /// <summary>
        /// Добавляем запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            var dlg = new QuizeForm();
            if (dlg.ShowDialog(this) != DialogResult.OK) return;
            var columns = new Dictionary<string, object>
            {
                { "Name", dlg.tbName.Text },
                { "Contacts", dlg.tbContacts.Text },
                { "OfficeAddress", dlg.tbOfficeAddress.Text },
                { "Descriptor", dlg.tbDescriptor.Text }
            };
            try
            {
                //Helper.InsertTable("AirCompany", columns);
                //LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка вставки новой записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Редактируем запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCurrent_Click(object sender, EventArgs e)
        {
            //var selected = lvTable.SelectedItems[0];
            //var values = (object[])selected.Tag;
            //var dlg = new QuizeForm();
            //dlg.tbName.Text = $"{values[1]}";
            //dlg.tbDescriptor.Text = $"{values[2]}";
            //dlg.tbContacts.Text = $"{values[3]}";
            //dlg.tbOfficeAddress.Text = $"{values[4]}";
            //var result = dlg.ShowDialog(this);
            //if (result != DialogResult.OK && result != DialogResult.Yes)
            //    return;
            //var id = (int)values[0];
            //var columns = new Dictionary<string, object>
            //{
            //    { "Id", id },
            //    { "Name", dlg.tbName.Text },
            //    { "Contacts", dlg.tbContacts.Text },
            //    { "OfficeAddress", dlg.tbOfficeAddress.Text },
            //    { "Descriptor", dlg.tbDescriptor.Text }
            //};
            try
            {
                //Helper.UpdateTable("AirCompany", columns);
                //LoadTable(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка изменения записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удаляем запись
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCurrent_Click(object sender, EventArgs e)
        {
            // запрос пользователя для закрытия программы
            if (MessageBox.Show(this, "Удалить теущую запись?", "Подтверждение действия",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;
            //var selected = lvTable.SelectedItems[0];
            //var values = (object[])selected.Tag;
            //var id = (int)values[0];
            //var columns = new Dictionary<string, object>
            //{
            //    { "Id", id }
            //};
            try
            {
                //Helper.DeleteTable("AirCompany", columns);
                //LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка удаления записи", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool CanPaste()
        {
            return Clipboard.GetDataObject() is DataObject retrievedData && retrievedData.ContainsText();
        }

        private List<Tournament> tournaments = [];

        private void PasteFromClipboard()
        {
            if (Clipboard.GetDataObject() is DataObject retrievedData && retrievedData.ContainsText())
            {
                var text = retrievedData.GetText().TrimStart();
                if (text.StartsWith("<?xml version=\"1.0\" encoding=\"UTF-8\"?>"))
                {
                    var xdoc = XDocument.Parse(text);
                    var xtournament = xdoc.Element("tournament");
                    if (xtournament != null)
                    {
                        var atype = $"{xtournament.Element("Type")?.Value}";
                        Tournament? tournament = null;
                        if (atype == "Ч")
                        {
                            var tid = $"{xtournament.Element("Id")?.Value}";
                            if (!tournaments.Any(x => x.id == tid))
                            {
                                tournament = new()
                                {
                                    type = atype,
                                    id = tid,
                                    parentId = $"{xtournament.Element("ParentId")?.Value}",
                                    title = $"{xtournament.Element("Title")?.Value}",
                                    number = $"{xtournament.Element("Number")?.Value}",
                                    editors = $"{xtournament.Element("Editors")?.Value}",
                                    createdAt = $"{xtournament.Element("CreatedAt")?.Value}",
                                };
                                tournaments.Add(tournament);
                            }
                            else
                                tournament = tournaments.First(x => x.id == tid);
                        }
                        foreach (XElement xtour in xtournament.Elements("tour"))
                        {
                            atype = $"{xtour.Element("Type")?.Value}";
                            var rid = $"{xtour.Element("Id")?.Value}";
                            var pid = $"{xtour.Element("ParentId")?.Value}";
                            if (atype == "Т" && tournament != null && pid == tournament.id)
                            {
                                if (!tournament.tours.Any(x => x.id == rid))
                                {
                                    Tour tour = new()
                                    {
                                        type = atype,
                                        id = rid,
                                        parentId = pid,
                                        title = $"{xtour.Element("Title")?.Value}",
                                        number = $"{xtour.Element("Number")?.Value}",
                                        editors = $"{xtour.Element("Editors")?.Value}",
                                        createdAt = $"{xtour.Element("CreatedAt")?.Value}",
                                    };
                                    tournament.tours.Add(tour);
                                }
                            }
                        }

                        foreach (XElement xquestion in xtournament.Elements("question"))
                        {
                            atype = $"{xquestion.Element("Type")?.Value}";
                            var qid = $"{xquestion.Element("QuestionId")?.Value}";
                            var pid = $"{xquestion.Element("ParentId")?.Value}";
                            var found = false;
                            Tour? tr = null;
                            foreach (var tt in tournaments)
                            {
                                if (tt.tours.Any(x => x.id == pid))
                                {
                                    found = true;
                                    tr = tt.tours.First(x => x.id == pid);
                                    break;
                                }
                            }
                            if (tr != null && atype == "Ч" && found)
                            {
                                if (!tr.questions.Any(x => x.questionId == qid))
                                {
                                    Question question = new()
                                    {
                                        type = atype,
                                        questionId = qid,
                                        parentId = pid,
                                        title = $"{xquestion.Element("Title")?.Value}",
                                        number = $"{xquestion.Element("Number")?.Value}",
                                        question = $"{xquestion.Element("Question")?.Value}",
                                        answer = $"{xquestion.Element("Answer")?.Value}",
                                        authors = $"{xquestion.Element("Authors")?.Value}",
                                        sources = $"{xquestion.Element("Sources")?.Value}",
                                        comments = $"{xquestion.Element("Comments")?.Value}",
                                    };
                                    tr.questions.Add(question);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void timerDataChecker_Tick(object sender, EventArgs e)
        {
            btnAppendFromClipboard.Visible = CanPaste();
        }

        private void btnAppendFromClipboard_Click(object sender, EventArgs e)
        {
            PasteFromClipboard();
            SaveContent();
            FillTree();
        }

        private void SaveContent()
        {
            var text = JsonConvert.SerializeObject(tournaments);
            var file = Path.Combine(Path.ChangeExtension(Application.ExecutablePath, ".json"));
            File.WriteAllText(file, text);
        }

        private void LoadContent()
        {
            var file = Path.Combine(Path.ChangeExtension(Application.ExecutablePath, ".json"));
            if (File.Exists(file))
            {
                var text = File.ReadAllText(file);
                var items = JsonConvert.DeserializeObject<List<Tournament>>(text);
                tournaments.Clear();
                if (items != null)
                    tournaments.AddRange(items);
                FillTree();
            }
        }

        private string idTournament = string.Empty;
        private string idTour = string.Empty;
        private string idQuestion = string.Empty;

        private void FillTree()
        {
            if (tvTurnaments.SelectedNode != null)
            {
                idTournament = string.Empty;
                idTour = string.Empty;
                idQuestion = string.Empty;
                if (tvTurnaments.SelectedNode.Tag is Tournament tournament1)
                    idTournament = tournament1.id;
                else if (tvTurnaments.SelectedNode.Tag is Tour tour1)
                {
                    if (tvTurnaments.SelectedNode.Parent.Tag is Tournament tournament2)
                        idTournament = tournament2.id;
                    idTour = tour1.id;
                }
                else if (tvTurnaments.SelectedNode.Tag is Question question1)
                {
                    if (tvTurnaments.SelectedNode.Parent.Parent.Tag is Tournament tournament3)
                        idTournament = tournament3.id;
                    if (tvTurnaments.SelectedNode.Parent.Tag is Tournament tour3)
                        idTour = tour3.id;
                    idQuestion = question1.questionId;
                }
            }
            tvTurnaments.Nodes.Clear();
            foreach (var tournament in tournaments)
            {
                var nodeTournament = new TreeNode() { Text = tournament.title, Tag = tournament };
                tvTurnaments.Nodes.Add(nodeTournament);
                if (idTournament == tournament.id)
                    tvTurnaments.SelectedNode = nodeTournament;
                foreach (var tour in tournament.tours)
                {
                    var nodeTour = new TreeNode() { Text = tour.title, Tag = tour };
                    nodeTournament.Nodes.Add(nodeTour);
                    if (idTour == tour.id)
                        tvTurnaments.SelectedNode = nodeTour;
                    foreach (var question in tour.questions)
                    {
                        var nodeQuestion = new TreeNode() { Text = question.number + "-й вопрос", Tag = question };
                        nodeTour.Nodes.Add(nodeQuestion);
                        if (idQuestion == question.questionId)
                            tvTurnaments.SelectedNode = nodeQuestion;
                    }
                }
            }
        }

        public class Question
        {
            public string type = string.Empty;
            public string questionId = string.Empty;
            public string parentId = string.Empty;
            public string title = string.Empty;
            public string number = string.Empty;
            public string question = string.Empty;
            public string answer = string.Empty;
            public string authors = string.Empty;
            public string sources = string.Empty;
            public string comments = string.Empty;
        }

        public class Tour
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public string parentId = string.Empty;
            public string title = string.Empty;
            public string number = string.Empty;
            public string editors = string.Empty;
            public string createdAt = string.Empty;
            public List<Question> questions = [];
        }

        public class Tournament
        {
            public string type = string.Empty;
            public string id = string.Empty;
            public string parentId = string.Empty;
            public string title = string.Empty;
            public string number = string.Empty;
            public string editors = string.Empty;
            public string createdAt = string.Empty;
            public List<Tour> tours = [];
        }

        private void tvTurnaments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panChildView.Controls.Clear();
            var node = tvTurnaments.SelectedNode;
            if (node != null)
            {
                if (node.Tag is Tournament tournament)
                {
                    QuestionsUC questionsUC = new() { Dock = DockStyle.Fill };
                    questionsUC.UpdateTable(tournament);
                    panChildView.Controls.Add(questionsUC);
                }
                else if (node.Tag is Tour tour)
                {
                    QuestionsUC questionsUC = new() { Dock = DockStyle.Fill };
                    questionsUC.UpdateTable(tour);
                    panChildView.Controls.Add(questionsUC);
                }
                else if (node.Tag is Question question && node.Parent.Tag is Tour tour3 && node.Parent.Parent.Tag is Tournament tournament3)
                {
                    AnswerUC answerUC = new() { Dock = DockStyle.Fill };
                    answerUC.UpdateTable(question, tour3, tournament3);
                    panChildView.Controls.Add(answerUC);
                }
            }
        }
    }
}
