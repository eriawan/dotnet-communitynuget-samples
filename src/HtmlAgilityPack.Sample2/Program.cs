using System;

namespace HtmlAgilityPack.Sample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample usage of HtmlAgilityPack v1.8.1");
            Console.WriteLine("Sample 1: Parser sample with string and search using XPath");
            String htmlWithFullHeader = @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(htmlWithFullHeader);

            Console.WriteLine("Before: (full HTML)");
            Console.WriteLine(htmlWithFullHeader);
            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");
            Console.WriteLine("After calling htmlDoc.DocumentNode.SelectSingleNode(\"//body\")");
            Console.WriteLine(htmlBody.OuterHtml);
        }
    }
}