using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace CV_maker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var doc = new Document(PageSize.A4);

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(@"D:\cv.pdf", FileMode.Create));
                Chunk chunk = new Chunk("A chunk represents an isolated string.\n ");

                doc.Open();
                Phrase phrase = new Phrase();

                for (int i = 0; i < 3; i++)
                {
                    phrase.Add(chunk);
                    doc.Add(phrase);
                }

                doc.NewPage();

                doc.Add(new Chunk("text", new Font(Font.FontFamily.TIMES_ROMAN, 30.5F)));
            }
            catch (DocumentException dex)

            {
                throw (dex);
            }
            catch (IOException ioex)

            {
                throw (ioex);
            }
            finally

            {
                doc.Close();
            }
        }
    }
}