using System;

using Foxit.PDF;
using Foxit.PDF.Merger;
using Foxit.PDF.PageElements;

namespace PDFHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();
            ImportedPage page;

            try
            {
                for(int i = 1; i <= 10; i++)
                {
                    page = new ImportedPage(@"../../PDFs/sample.pdf", i);
                    page.BackgroundElements.Add(new BackgroundImage(@"../../img/background.jpg"));
                    doc.Pages.Add(page);
                }                    
            }
            catch(Exception e)
            { }

            doc.Draw(@"../../PDFs/result.pdf");
        }
    }
}
