using System;
using System.IO;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace _04.DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string remoteUri = "https://cdn.jpegmini.com/user/images/";
                string fileName = "slider_puffin_before_mobile.jpg", myStringWebResource = null;
                WebClient myWebClient = new WebClient();
                myStringWebResource = remoteUri + fileName;
                myWebClient.DownloadFile(myStringWebResource, fileName);
                Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Directory.GetCurrentDirectory());
            }
            catch (WebException)
            {
                Console.WriteLine("The remote server returned an error: (404) Not Found.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The address parameter is null.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads.");
            }
            finally
            {
                Console.WriteLine("Used resources :");
                Console.WriteLine("MSDN : WebClient.DownloadFile Method");
            }
        }
    }
}
