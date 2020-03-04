using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace PresentationRepresentation
{
    class MarkdownParser
    {
        private List<string> lines = new List<string>();
        private List<Slide> slides = new List<Slide>();

        public MarkdownParser(string filePath)
        {
            readFile(filePath);
        }

        public List<Slide> convertToSlides()
        {
            Slide slide = new Slide();

            foreach (var item in lines)
            {
                //Headers
                checkIfHeader(item, slide);

                //Bullets
                checkifBullet(item, slide);


                if (item.StartsWith("---"))
                {
                    slides.Add(slide);
                    slide = new Slide();
                }
            }
            slides.Add(slide);
            return slides;
        }

        private void checkIfHeader(string item, Slide slide)
        {
            if (item.StartsWith("# "))
            {
                slide.Title.Name = "Header 1";
                slide.Title.Content = item.Substring(2);
                slide.Title.Size = Header.One;
            }

            if (item.StartsWith("## "))
            {
                slide.Title.Name = "Header 2";
                slide.Title.Content = item.Substring(3);
                slide.Title.Size = Header.Two;
            }

            if (item.StartsWith("### "))
            {
                slide.Title.Name = "Header 3";
                slide.Title.Content = item.Substring(4);
                slide.Title.Size = Header.Three;
            }

            if (item.StartsWith("#### "))
            {
                slide.Title.Name = "Header 4";
                slide.Title.Content = item.Substring(5);
                slide.Title.Size = Header.Four;
            }

            if (item.StartsWith("##### "))
            {
                slide.Title.Name = "Header 5";
                slide.Title.Content = item.Substring(6);
                slide.Title.Size = Header.Five;
            }

            if (item.StartsWith("###### "))
            {
                slide.Title.Name = "Header 6";
                slide.Title.Content = item.Substring(7);
                slide.Title.Size = Header.Six;
            }
        }

        private void checkifBullet(string item, Slide slide)
        {
            Regex rx = new Regex("^[*+-] ");
            if (rx.IsMatch(item) )
            {
                Text bullet = new Text("Bullet", item.Substring(2), 32);
                slide.Bullets.Add(bullet);
            }
        }

        private void readFile(string filePath)
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }

    static class Header
    {
        public static int One = 80;
        public static int Two = 60;
        public static int Three = 48;
        public static int Four = 40;
        public static int Five = 32;
        public static int Six = 28;
    }
}
