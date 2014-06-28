namespace ParseAnUrl
{
    using System;

    public class ParseAnUrl
    {
        public static void Main()
        {
            // Write a program that parses an URL address given in the format:
            // [protocol]://[server]/[resource]
            // and extracts from it the [protocol], [server] and [resource] elements. 
            // For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
            // [protocol] = "http"
            // [server] = "www.devbg.org"
            // [resource] = "/forum/index.php"
            string url = "http://www.devbg.org/forum/index.php";

            string[] arrayUrl = url.Split(':');
            string protocol = arrayUrl[0];
            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            string rest = arrayUrl[1].Substring(2);
            int index = rest.IndexOf('/');
            string server = rest.Substring(0, index);
            Console.WriteLine("[server] = \"{0}\"", server);
            string resource = rest.Substring(index);
            Console.WriteLine("[resource] = \"{0}\"", resource);
        }
    }
}