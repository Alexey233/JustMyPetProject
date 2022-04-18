using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Phoenix.Controllers
{
    public class ConverterController : Controller
    {

        public IActionResult JPGToPDF()
        {
            return View();
        }


       [HttpPost]
        public IActionResult JPGToPDF(IList<IFormFile> files)
        {
            PdfDocument document = new PdfDocument();
           

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    MemoryStream file = new MemoryStream();
                    formFile.CopyTo(file);


                    if (formFile.ContentType == "image/jpeg")
                    {
                        PdfBitmap bitmap = new PdfBitmap(file);
                        PdfPage page = document.Pages.Add();
                        PdfGraphics graphics = page.Graphics;

                        page.Graphics.DrawImage(bitmap,0,0);

                    }
                    file.Dispose();
                }
            }



            MemoryStream stream = new MemoryStream();
            document.Save(stream);

            stream.Position = 0;
            document.Close(true);

            string contentType = "application/pdf";
            string fileName = "Output.pdf";

            return File(stream, contentType, fileName);
        }
    }
}
