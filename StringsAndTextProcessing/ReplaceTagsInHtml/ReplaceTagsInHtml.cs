namespace ReplaceTagsInHtml
{
    using System;

    public class ReplaceTagsInHtml
    {
        public static void Main()
        {
            /*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a>
            with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
            <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
            Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
            
            <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
            Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>*/
            string inputText = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string text = inputText.Replace("<a href=", "[URL=");
            text = text.Replace("\"", string.Empty);
            text = text.Replace("</a>", "[/URL]");
            char[] newText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>' && i > 2 && i < text.Length - 1)
                {
                    newText[i] = ']';
                }
                else
                {
                    newText[i] = text[i];
                }
            }

            Console.WriteLine(newText);
        }
    }
}