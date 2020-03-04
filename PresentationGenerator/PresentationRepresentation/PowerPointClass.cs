using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;

namespace PresentationRepresentation
{
    class PowerPointClass
    {
        private Application pptApplication;
        private  Slides slides;
        private _Slide slide;
        private TextRange objText;
        private string pptPath;

       
        public PowerPointClass(string pptPath, List<Slide> list) {
            this.pptPath = pptPath;
            deleteIfExists();
            
            pptApplication = new Application();
            Presentation presentation = pptApplication.Presentations.Add(MsoTriState.msoTrue);
            CustomLayout customLayout = presentation.SlideMaster.CustomLayouts[PpSlideLayout.ppLayoutText];
            this.slides = presentation.Slides;



            int slideIndex = 1;
            foreach (var item in list)
            {
                // slide 
                slide = slides.AddSlide(slideIndex++, customLayout);

                objText = slide.Shapes[1].TextFrame.TextRange;
                objText.Text = item.Title.Content;
                objText.Font.Size = item.Title.Size;
                
                
                foreach (var bullet in item.Bullets)
                {
                    objText = slide.Shapes[2].TextFrame.TextRange;
                    objText.Text = bullet.Content;
                    objText.Font.Size = bullet.Size;
                }

            }

            presentation.SaveAs(pptPath, 
                PpSaveAsFileType.ppSaveAsDefault, 
                MsoTriState.msoTrue);

            presentation.Close();
            try { 
            pptApplication.Quit();
            }
            catch (Exception)
            {
                Console.WriteLine("Couldn't exit PowerPoint Application!");
            }
        }
        private void deleteIfExists()
        {
            if (File.Exists(this.pptPath))
            {
                try
                {
                    File.Delete(this.pptPath);
                }
                catch(Exception)
                {
                    throw new Exception("File is currently in use!");
                }
            }

        }

    }
}
