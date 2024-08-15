using DesafioCRUD.Ioc;
using Ninject;

namespace DesafioCRUD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            Config.ConfigurarInjecao();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenuPrincipal());
        }
    }
}