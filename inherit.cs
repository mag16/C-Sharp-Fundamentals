using System;

namespace Inheritance
{
    public class Text : InheritanceObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added a link to" + url);
        } 

    }

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
            text.Duplicate();
        }

    }





}