using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            ImportedPage page = new ImportedPage(@"../../PDFs/sample.pdf", 1);
            doc.Pages.Add(page);

            //page.Elements.Add(new BackgroundImage(@"../../img/background.jpg"));            

            doc.Draw(@"../../PDFs/result.pdf");
        }
    }
}
