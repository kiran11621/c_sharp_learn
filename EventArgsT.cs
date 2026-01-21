using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class DownloadEventArgs : EventArgs
    {
        public string FileName { get; }
        public int Size { get; }

        public DownloadEventArgs(string fileName, int size)
        {
            FileName = fileName;
            Size = size;
        }
    }

    public class Download
    {
        public event EventHandler<DownloadEventArgs> DownloadCompleted;

        public void StartDownload(string fileName)
        {
            DownloadCompleted?.Invoke(
                this,
                new DownloadEventArgs("file.zip", 200));
        }
    }

    public class EventArgsT
    {
        public void OnDownloadCompleted(object sender, DownloadEventArgs e)
        {
            Console.WriteLine("FILE " + e.FileName + e.Size);
        }

        public void Main()
        {
            Download d = new Download();
            d.DownloadCompleted += OnDownloadCompleted;
            d.StartDownload("movei");
        }
    }
}
