using IgazsagTabla;

namespace IgazsagTabla
    {
    internal static class Program
        {
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
            }
        }
    }