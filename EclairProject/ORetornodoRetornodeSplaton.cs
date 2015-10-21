using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text.pdf;

namespace EclairProject
{
    class ORetornodoRetornodeSplaton
    {
        public static void ReplacePdfForm()
        {
            string fileNameExisting = @"C:\Users\Windows\Desktop\CONTRATO DE PRESTAÇÃO DE SERVIÇOS V2.pdf";
            string fileNameNew = @"C:\Users\Windows\Desktop\lols.pdf";

            using (var existingFileStream = new FileStream(fileNameExisting, FileMode.Open))
            using (var newFileStream = new FileStream(fileNameNew, FileMode.Create))
            {
                var pdfReader = new PdfReader(existingFileStream);
                var stamper = new PdfStamper(pdfReader, newFileStream);
                var form = stamper.AcroFields;
                var fieldKeys = form.Fields.Keys;

                foreach (string fieldKey in fieldKeys)
                {
                    form.SetField(fieldKey, "REPLACED!");
                }

                stamper.FormFlattening = true;
                stamper.PartialFormFlattening("field1");

                stamper.Close();
                pdfReader.Close();
            }
        }
    }
}
