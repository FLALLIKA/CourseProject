using CourseProject.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CourseProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new EditorView(Color.White));
            Application.Run(new MDIParentView());
        }
    }
}
