namespace CourseProject.View
{
    partial class MDIParentView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParentView));
            this.ParentMenuStrip = new System.Windows.Forms.MenuStrip();
            this.EditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenInEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenEmptyEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParentColorDialog = new System.Windows.Forms.ColorDialog();
            this.ParentOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ParentMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ParentMenuStrip
            // 
            this.ParentMenuStrip.AllowMerge = false;
            this.ParentMenuStrip.AutoSize = false;
            this.ParentMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditorToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.ParentMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ParentMenuStrip.Name = "ParentMenuStrip";
            this.ParentMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.ParentMenuStrip.TabIndex = 1;
            // 
            // EditorToolStripMenuItem
            // 
            this.EditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenInEditorToolStripMenuItem,
            this.OpenEmptyEditorToolStripMenuItem});
            this.EditorToolStripMenuItem.Name = "EditorToolStripMenuItem";
            this.EditorToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.EditorToolStripMenuItem.Text = "Редактор";
            // 
            // OpenInEditorToolStripMenuItem
            // 
            this.OpenInEditorToolStripMenuItem.Name = "OpenInEditorToolStripMenuItem";
            this.OpenInEditorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.OpenInEditorToolStripMenuItem.Text = "Открыть в редакторе";
            this.OpenInEditorToolStripMenuItem.Click += new System.EventHandler(this.OpenInEditorToolStripMenuItem_Click);
            // 
            // OpenEmptyEditorToolStripMenuItem
            // 
            this.OpenEmptyEditorToolStripMenuItem.Name = "OpenEmptyEditorToolStripMenuItem";
            this.OpenEmptyEditorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.OpenEmptyEditorToolStripMenuItem.Text = "Пустой редактор";
            this.OpenEmptyEditorToolStripMenuItem.Click += new System.EventHandler(this.OpenEmptyEditorToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // ParentColorDialog
            // 
            this.ParentColorDialog.Color = System.Drawing.Color.White;
            // 
            // ParentOpenFileDialog
            // 
            this.ParentOpenFileDialog.FileName = "openFileDialog1";
            // 
            // MDIParentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ParentMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ParentMenuStrip;
            this.Name = "MDIParentView";
            this.Text = "Редактор изображений";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ParentMenuStrip.ResumeLayout(false);
            this.ParentMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip ParentMenuStrip;
        private System.Windows.Forms.ColorDialog ParentColorDialog;
        private System.Windows.Forms.ToolStripMenuItem EditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenInEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenEmptyEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ParentOpenFileDialog;
    }
}