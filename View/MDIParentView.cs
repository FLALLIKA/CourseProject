using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject.View
{
    public partial class MDIParentView: Form
    {
        // Конструктор
        public MDIParentView()
        {
            InitializeComponent();
            ParentColorDialog.FullOpen = true;
        }

        // Октрыть пустой редактор
        private void OpenEmptyEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParentColorDialog.ShowDialog() == DialogResult.OK)
            {
                EditorView f = new EditorView(ParentColorDialog.Color)
                {
                    MdiParent = this,
                    Text = "Редактор - " + MdiChildren.Length.ToString(),
                };

                f.Show();
            }
        }

        // Открыть изображенеи в редакторе
        private void OpenInEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ParentOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(ParentOpenFileDialog.FileName);

                EditorView f = new EditorView(image)
                {
                    MdiParent = this,
                    Text = "Редактор - " + ParentOpenFileDialog.FileName,
                };

                f.Show();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (
                "Редактор изображений | Автор Рубцов И.С. ЗЦИС-26",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
