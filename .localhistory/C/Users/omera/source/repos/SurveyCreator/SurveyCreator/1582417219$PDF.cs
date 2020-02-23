using System;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace SurveyCreator
{
    class PDF
    {
        ANKET ANKET;
        static Document document = null;
        static Table table = null;

        public PDF(ANKET anket)
        {
            ANKET = anket;
            document = new Document();
        }

        public void OLUSTUR()
        {

            CreateDefaultStyles();
            CreatePDFSection();
        }

        // PDF içeriğinde kullanılacak olan stiller belirlenir. Bu Style tiplerini HTML içeriğindeki style kavramına benzetebiliriz. 
        void CreateDefaultStyles()
        {
            Style style = document.Styles["Normal"];
            style.Font.Name = "Arial";
            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("12cm", TabAlignment.Right);
            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Table isimli bir style oluşturuyoruz. Normal isimli Style' dan türemekte 
            style = document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Arial";
            style.Font.Size = 9;

            // Normal isimli Style' ı baz alan Reference isimli bir Style oluşturuyoruz 
            style = document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "3mm";
            style.ParagraphFormat.SpaceAfter = "3mm";
            style.ParagraphFormat.TabStops.AddTabStop("12cm", TabAlignment.Right);
        }

        // PDF Sayfası üretilir. 
        void CreatePDFSection()
        {
            // Landscape olacak şekilde dokümanın yönünü belirliyoruz 
            document.DefaultPageSetup.Orientation = ANKET.SayfaYonu;

            // İçeriğimizi koyacağımız bir Section oluşturuyoruz 
            Section section = document.AddSection();

            table = section.AddTable();
            table.Style = "Table";

            Column columnHeader;
            columnHeader = table.AddColumn(Unit.FromCentimeter(13));
            columnHeader.Format.Alignment = ParagraphAlignment.Left;
            columnHeader = table.AddColumn(Unit.FromCentimeter(4));
            columnHeader.Format.Alignment = ParagraphAlignment.Left;

            Row rowHeader = table.AddRow();
            rowHeader.Cells[0].Shading.Color = Color.Empty;
            rowHeader.Cells[0].AddParagraph(ANKET.AketBasligi);
            rowHeader.Cells[0].Format.Font.Bold = true;
            rowHeader.Cells[0].Format.Font.Size = 20;


        }

        public void KAYDET(String filePath)
        {
            try
            {
                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
                pdfRenderer.Document = document;
                pdfRenderer.RenderDocument();
                pdfRenderer.Save(filePath);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
