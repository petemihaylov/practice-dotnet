using System;
using System.Collections.Generic;

namespace PresentationRepresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            string markdownPath;
            string textFilePath;
            string jsonFilePath;
            string pptFilePath;

            char response;
            Console.Write("> Do you want to read from '.txt' file? y\\n: ");
            try
            {
                response = Convert.ToChar(Console.ReadLine());
            }
            catch (Exception) { throw new Exception("Wrong input!"); }
            Console.Clear();

            if(response == 'y')

            {
                /* .txt file */
                Console.Write("> *.txt path: ");
                textFilePath = Console.ReadLine();
                Console.Clear();

                Console.Write("> *.json path: ");
                jsonFilePath = Console.ReadLine();
                Console.Clear();

                JsonSerializer jsonSerializer = new JsonSerializer(textFilePath, jsonFilePath);
                jsonSerializer.ReadFile();
                List<Slide> list = jsonSerializer.SerializeObject();


                Console.Write("> *pptx path: ");
                pptFilePath = Console.ReadLine();
                Console.Clear();
              
                new PowerPointClass(pptFilePath, list);
            }
            else
            {

                /* Markdown file */
                 Console.Write("> Do you want to read from '.md' file? y\\n:");
                 char res = Convert.ToChar(Console.ReadLine());

                if (res == 'y')
                {
                    Console.Write("> *.md path: ");
                    markdownPath = Console.ReadLine();
                    Console.Clear();
                    
                    MarkdownParser markdown = new MarkdownParser(markdownPath);
                    List<Slide> list = markdown.convertToSlides();

                    Console.Write("> *pptx path: ");
                    pptFilePath = Console.ReadLine();
                    Console.Clear();

                    
                    new PowerPointClass(pptFilePath, list);

                }
            }

        }
    }
}
