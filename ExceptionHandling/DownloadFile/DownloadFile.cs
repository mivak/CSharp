/* Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
* and stores it the current directory. Find in Google how to download files in C#. 
* Be sure to catch all exceptions and to free any used resources in the finally block.*/

namespace DownloadFile
{
    using System;
    using System.Net;
    class DownloadFile
    {
        static void Main()
        {
            try
            {
                WebClient webclient = new WebClient();
                webclient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"c:\CSharpDownload.jpg");
                Console.WriteLine("Download Complete");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null");
            }
            catch (WebException)
            {
                Console.WriteLine("The URI formed by combining BaseAddress and address is invalid\nor\nFilename is null or empty\nor\nThe file does not exist\nor\nAn error occured while downloading data");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads");
            }
            catch (Exception)
            {
                Console.WriteLine("Please check again the adrress and the download path");
            }
        }
    }
}