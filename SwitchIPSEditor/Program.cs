using Dark.Net;

namespace SwitchIPSEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const Theme theme = Theme.Auto;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DarkNet.Instance.SetCurrentProcessTheme(theme);
            ApplicationConfiguration.Initialize();
            var form = new Form1();
            DarkNet.Instance.SetWindowThemeForms(form, theme);
            DarkNet.Instance.UserDefaultAppThemeIsDarkChanged += form.Form_ThemeChanged;
            Application.Run(form);
        }
    }
}