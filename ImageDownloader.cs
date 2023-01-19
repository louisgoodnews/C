using System;
using System.Net;

namespace ImageDownloader
{
    public class ImageDownloader
    {
        static void Main(string[] args)
        {
            string targetDrive = "";
            string targetDirectory = "";

            string artist = "";
            string baseUrl = "";

            string fileType = "jpg";

            Int32 startIndex = 0;
            Int32 maxIndex = 0;
            
            using WebClient webClient = new WebClient();
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            for (int i = startIndex; i < maxIndex; i++)
            {
                string subUrl = $"{baseUrl}";
                string fileDestination = $"{targetDrive}\\{targetDirectory}\\{artist}\\{i}.{fileType}";

                webClient.DownloadFileAsync(subUrl, fileDestination);
            }
        }
    }
}

