/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
* reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
* Be sure to catch all possible exceptions and print user-friendly error messages.*/

namespace PrintFile
{
    using System;
    using System.IO;

    class PrintFile
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Please enter the path for the file");
                string path = Console.ReadLine();
                //string path = @"C:\WINDOWS\win.ini";
                // string path = @"D:\Programs\Microsoft Office ProPlus 2013 VL RTL x64 en-US Sep2013\Office ProPlus 2013 VL.txt";
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path is null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The path might contain one or more invalid characters or the path is zero-length string");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path should be less than 248 characters");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Are you sure that you have entered the right path to the file");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occured while opening the file");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The file is read-only\nor\nThis operation is not supported on the current platform\nor\nThe path has specified a directory\nor\nThe caller does not have the required permission");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The path is in an invalid format");
            }
            catch (Exception)
            {
                Console.WriteLine("Please check the path you are trying to enter");
            }
        }
    }
}