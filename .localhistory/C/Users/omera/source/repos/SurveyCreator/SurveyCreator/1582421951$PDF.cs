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
            CreatePDFHeader();
            CreatePDFSurvey();
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

        // PDF Sayfası ve başlık bölümü üretilir.
        void CreatePDFHeader()
        {
            // Landscape olacak şekilde dokümanın yönünü belirliyoruz 
            document.DefaultPageSetup.Orientation = ANKET.SayfaYonu;

            // İçeriğimizi koyacağımız bir Section oluşturuyoruz 
            Section section = document.AddSection();

            table = section.AddTable();
            table.Style = "Table";

            #region Üst Bilgi kısmı

            Paragraph paragraph = section.Headers.Primary.AddParagraph();
            paragraph.AddText(ANKET.UstBilgi);
            paragraph.Format.Font.Size = 10;
            paragraph.Format.Font.Color = Colors.LightGray;
            paragraph.Format.Alignment = ParagraphAlignment.Left;

            #endregion Header kısmı

            #region Alt Bilgi kısmı

            paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText(ANKET.AltBilgi);
            paragraph.Format.Font.Size = 10;
            paragraph.Format.Font.Color = Colors.LightGray;
            paragraph.Format.Alignment = ParagraphAlignment.Left;

            if (ANKET.SayfaSayisiGoster)
            {
                paragraph = section.Footers.Primary.AddParagraph();
                paragraph.AddPageField();
                paragraph.Format.Font.Size = 10;
                paragraph.Format.Font.Color = Colors.LightGray;
                paragraph.Format.Alignment = ParagraphAlignment.Right;
            }

            #endregion Footer kısmı

            #region Başlık ve Açıklama Kısmı
            Column columnHeader;
            columnHeader = table.AddColumn(Unit.FromCentimeter(16.3));
            columnHeader.Format.Alignment = ParagraphAlignment.Left;

            Row rowHeader = table.AddRow();
            rowHeader.Cells[0].Shading.Color = Color.Empty;
            rowHeader.Cells[0].AddParagraph(ANKET.AketBasligi);
            rowHeader.Cells[0].Format.Font.Bold = true;
            rowHeader.Cells[0].Format.Font.Size = 15;
            rowHeader.BottomPadding = 5;

            rowHeader = table.AddRow();
            rowHeader.Cells[0].Shading.Color = Color.Empty;
            rowHeader.Cells[0].AddParagraph(ANKET.AnketAciklamasi);
            rowHeader.Cells[0].Format.Font.Size = 10;
            rowHeader.Borders.Bottom.Color = Colors.Gray;
            rowHeader.BottomPadding = 5;
            rowHeader.Borders.Bottom.Color = Colors.Gray;

            paragraph = section.AddParagraph();
            paragraph.AddText(ANKET.AketBasligi);
            paragraph.Format.Font.Size = 15;
            //paragraph.Format.Font.Color = Colors.LightGray;
            paragraph.Format.Alignment = ParagraphAlignment.Left;

            paragraph = section.AddParagraph();
            paragraph.AddText(ANKET.AnketAciklamasi);
            paragraph.Format.Font.Size = 10;
            //paragraph.Format.Font.Color = Colors.LightGray;
            paragraph.Format.Alignment = ParagraphAlignment.Left;

            paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.Format.Borders.Bottom = new Border() { Width = "1pt", Color = Colors.DarkGray };

            #endregion

        }

        //Pdf soruları eklenir
        void CreatePDFSurvey()
        {
            foreach (SORULAR item in ANKET.sorular)
            {
                if (item.SoruTipi == enSoruTipleri.KisaMetin)
                {

                }
                else if (item.SoruTipi==enSoruTipleri.UzunMetin)
                {

                }
                else if (item.SoruTipi == enSoruTipleri.Secenekli)
                {

                }
                else if (item.SoruTipi == enSoruTipleri.Puanli)
                {

                }
            }
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
