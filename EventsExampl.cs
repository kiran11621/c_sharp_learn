using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public delegate void OnDownloadComplete(object sender, EventArgs e);

    public class Downloader
    {
        public event EventHandler DownloadComplete;

        public void StartDownload()
        {
            Console.WriteLine("Downloading file...");

            Thread.Sleep(1000);

            Console.WriteLine("Download finished");

            //DownloadComplete?.Invoke("File downloaded successfully");
            DownloadComplete?.Invoke(this, EventArgs.Empty);
        }
    }

    public class NotificationService
    {
        public void Log(string msg)
        {
            Console.WriteLine("LOG: " + msg);
        }

        public void NotifyUser(string msg)
        {
            Console.WriteLine("NOTIFY USER: " + msg);
        }
    }


    public class EventsExampl
    {
        public void Main()
        {
            Downloader downloader = new Downloader();
            //NotificationService service = new NotificationService();

            //downloader.DownloadComplete += service.Log;
            //downloader.DownloadComplete += service.NotifyUser;

            downloader.StartDownload();
        }

        void OnDownloadComplete(object sender, EventArgs e)
        {
            Console.WriteLine("dssdddddddddddd" + e.ToString());
        }
    }
}
