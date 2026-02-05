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
    public partial class QuizesUC : UserControl
    {
        public QuizesUC()
        {
            InitializeComponent();
        }

        private void QuizesUC_Load(object sender, EventArgs e)
        {
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
            var selected = lvTable.SelectedItems[0];
            var values = (object[])selected.Tag;
            var dlg = new QuizeForm();
            dlg.tbName.Text = $"{values[1]}";
            dlg.tbDescriptor.Text = $"{values[2]}";
            dlg.tbContacts.Text = $"{values[3]}";
            dlg.tbOfficeAddress.Text = $"{values[4]}";
            var result = dlg.ShowDialog(this);
            if (result != DialogResult.OK && result != DialogResult.Yes)
                return;
            var id = (int)values[0];
            var columns = new Dictionary<string, object>
            {
                { "Id", id },
                { "Name", dlg.tbName.Text },
                { "Contacts", dlg.tbContacts.Text },
                { "OfficeAddress", dlg.tbOfficeAddress.Text },
                { "Descriptor", dlg.tbDescriptor.Text }
            };
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
            var selected = lvTable.SelectedItems[0];
            var values = (object[])selected.Tag;
            var id = (int)values[0];
            var columns = new Dictionary<string, object>
            {
                { "Id", id }
            };
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

        private void PasteFromClipboard()
        {
            if (Clipboard.GetDataObject() is DataObject retrievedData && retrievedData.ContainsText())
            {
                var text = retrievedData.GetText();
                QuestionData question = new();
                var order = QuestionOrder.None;
                List<QuestionData> questions = [];
                questions.Add(question);
                foreach (var line in text.Split("\r\n"))
                {
                    if (line.StartsWith("Чемпионат:"))
                        order = QuestionOrder.Championship;
                    else if (line.StartsWith("Дата:"))
                        order = QuestionOrder.Date;
                    else if (line.StartsWith("URL:"))
                        order = QuestionOrder.Url;
                    else if (line.StartsWith("Редактор:"))
                        order = QuestionOrder.Editor;
                    else if (line.StartsWith("Тур:"))
                        order = QuestionOrder.Tour;
                    else if (line.StartsWith("Вопрос ") && line.EndsWith(":"))
                    {
                        var snum = line.TrimEnd(':').Substring(6);
                        if (int.TryParse(snum, out int number))
                        {
                            question.QuestionNumber = number;
                            order = QuestionOrder.Question;
                        }
                    }
                    else if (line.StartsWith("Ответ:"))
                        order = QuestionOrder.Answer;
                    else if (line.StartsWith("Источник:"))
                        order = QuestionOrder.Source;
                    else if (line.StartsWith("Автор:"))
                        order = QuestionOrder.Author;
                    else if (line.StartsWith("Комментарий:"))
                        order = QuestionOrder.Comment;
                    else if (line == "")
                    {
                        if (order == QuestionOrder.Author)
                        {
                            // готовим новый вопрос
                            question = new QuestionData
                            {
                                Championship = question.Championship,
                                Date = question.Date,
                                Url = question.Url,
                                Tour = question.Tour,
                            };
                            questions.Add(question);
                        }
                        order = QuestionOrder.None;
                    }
                    else
                    {
                        switch (order)
                        {
                            case QuestionOrder.Championship:
                                question.Championship = line;
                                break;
                            case QuestionOrder.Date:
                                question.Date = DateTime.TryParse(line, out DateTime date) ? date : DateTime.MinValue;
                                break;
                            case QuestionOrder.Url:
                                question.Url = line;
                                break;
                            case QuestionOrder.Editor:
                                question.Editor = line;
                                break;
                            case QuestionOrder.Tour:
                                question.Tour = line;
                                break;
                            case QuestionOrder.Question:
                                question.Question.Add(line);
                                break;
                            case QuestionOrder.Answer:
                                question.Answer = line;
                                break;
                            case QuestionOrder.Comment:
                                question.Comment.Add(line);
                                break;
                            case QuestionOrder.Source:
                                question.Source.Add(line);
                                break;
                            case QuestionOrder.Author:
                                question.Author.Add(line);
                                break;
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
        }
    }

    public enum QuestionOrder
    {
        None,
        Championship,
        Date,
        Url,
        Editor,
        Tour,
        QuestionNumber,
        Question,
        Answer,
        Comment,
        Source,
        Author,
        Text
    }

    public class QuestionData
    {
        public string Championship { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Editor { get; set; } = string.Empty;
        public string Tour { get; set; } = string.Empty;
        public int QuestionNumber { get; set; }
        public List<string> Question { get; set; } = [];
        public string Answer { get; set; } = string.Empty;
        public List<string> Source { get; set; } = [];
        public List<string> Author { get; set; } = [];
        public List<string> Comment { get; set; } = [];

        public override string ToString()
        {
            return $"Ch:{Championship} Tour:{Tour} Q:{QuestionNumber} An:{Answer} Ed:{Editor} Autor:{string.Join(" ", Author)}";
        }

    }
}
