using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using YoutubeDownloader.Services;

namespace YoutubeDownloader
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            // In order to use dependency injection, I had to add the 2 lines below. Then I had to create the createhostbuilder method and add the services and form. 
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run((Form)ServiceProvider.GetService(typeof(YoutubeDownloaderForm))); // Here I had to use typeof instead of the usual constructor due to injecting the idownloadservice using dependency injection. Also have to cast it to form
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<YoutubeDownloaderForm>();
                    services.AddTransient<FileDetailsForm>();
                    services.AddTransient<IDownloadService, DownloadService>();
                });
        }
    }
}