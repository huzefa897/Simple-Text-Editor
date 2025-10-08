using System;
using System.Windows.Forms;

namespace A2___Simple_Text_Editor
{
    static class SimpleTextEditor
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm(true));
        }
    }
}
