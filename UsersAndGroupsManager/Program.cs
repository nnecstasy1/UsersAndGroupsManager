using ServiceAccessBL;

namespace UsersAndGroupsManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider serviceProvider = services.BuildServiceProvider();
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(serviceProvider));
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddHttpClient();
            services.AddTransient<IHttpClientService, HttpClientService>();
        }
    }
}