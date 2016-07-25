using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace PDFHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(@"../../PDFs/sample.pdf");
            Image image = Image.FromFile(@"../../img/background.jpg");

            int width = image.Width;
            int height = image.Height;
            float schale = 1.0f;
            //Size size = new Size((int)(width * schale), (int)(height * schale));
            Size size = new Size(width, height);
            Bitmap schaleImage = new Bitmap(image, size);

            PdfImage pdfImage = PdfImage.FromImage(schaleImage);
            PdfPageBase page0 = doc.Pages[0];
            //PointF position = new PointF((page0.Canvas.ClientSize.Width - schaleImage.Width) / 10, 210);
            PointF position = new PointF(-500, -210);
            page0.Canvas.SetTransparency(0.65f);
            page0.Canvas.DrawImage(pdfImage, position);
            page0.Canvas.SetTransparency(1.0f);


            doc.SaveToFile(@"../../PDFs/result.pdf");
            doc.Close();

        }
    }
}
