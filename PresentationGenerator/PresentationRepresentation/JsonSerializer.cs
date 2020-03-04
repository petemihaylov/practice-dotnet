using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PresentationRepresentation
{
    class JsonSerializer
    {
        private string txtFilePath;
        private string jsonFilePath;
        private List<string> lines = new List<string>();
        public JsonSerializer(string txtFilePath, string jsonFilePath)
        {
            this.txtFilePath = txtFilePath;
            this.jsonFilePath = jsonFilePath;
        }
        public List<string> ReadFile()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(txtFilePath))
                {
                    string line;
                    while (( line = sr.ReadLine()) != null)
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
            return lines;
        }

        public List<Slide> SerializeObject()
        {
            char[] separators = { ':', ';'};
            Slide slide = new Slide();
            List<Slide> listOfSlides = new List<Slide>();

            foreach (var line in lines)
            {
                string[] parts = line.Split(separators);
                if(!line.StartsWith("---"))
                {
                    slide = setProperties(slide, parts);
                }
                else
                {
                    listOfSlides.Add(slide);
                    slide = new Slide();
                }
            }

            listOfSlides.Add(slide);

            if (slide == null) return null;

            //delete old lines
            File.WriteAllText(jsonFilePath, String.Empty);

            string JsonResult = JsonConvert.SerializeObject(listOfSlides);
            using(var textWrite = new StreamWriter(jsonFilePath, true))
            {
                textWrite.WriteLine(JsonResult);
                textWrite.Close();
            }
            
            return listOfSlides;
        }

        private Slide setProperties(Slide slide, string[] parts)
        {
            if (parts[0] == null) return slide;
            switch (parts[0].ToLower())
            {
                case "title":
                    slide.Title.Content = parts[1];
                    slide.Title.Name = "Header 1";
                    slide.Title.Size = Header.One;
                    break;

                case "number":
                    slide.Number = int.Parse(parts[1]);
                    break;
                case "bullet":
                    Text bullet = new Text("Bullet",parts[1], 30);
                    slide.Bullets.Add(bullet);
                    break;
                default:
                    break;
            }
            return slide;
        }
            
    }
}