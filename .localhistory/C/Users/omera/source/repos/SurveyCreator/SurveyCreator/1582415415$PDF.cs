using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            #region Lisans + Logo
            table = section.AddTable();
            table.Style = "Table";

            Column columnHeader;
            columnHeader = table.AddColumn(Unit.FromCentimeter(13));
            columnHeader.Format.Alignment = ParagraphAlignment.Left;
            columnHeader = table.AddColumn(Unit.FromCentimeter(4));
            columnHeader.Format.Alignment = ParagraphAlignment.Right;

            Row rowHeader = table.AddRow();
            rowHeader.BottomPadding = 5;
            rowHeader.Cells[0].Shading.Color = Color.Empty;
            rowHeader.Cells[0].AddParagraph("Karali Çay");
            rowHeader.Cells[0].Format.Font.Bold = true;
            //rowHeader.Borders.Bottom.Color = Colors.Red;
            //rowHeader.Borders.Top.Color = Colors.Red;

            rowHeader.Cells[1].Shading.Color = Color.Empty;
            rowHeader.Cells[1].AddImage(Path.Combine(Environment.CurrentDirectory, "karali-cay-logo.jpg"));
            rowHeader.Cells[1].MergeDown = 3;
            //rowHeader.Borders.Bottom.Color = Colors.Red;

            rowHeader = table.AddRow();
            rowHeader.Cells[0].Shading.Color = Color.Empty;
            rowHeader.Cells[0].AddParagraph("Tophane mah.palandöken cad yeni haliçi no 49");
            //rowHeader.Borders.Bottom.Color = Colors.Red;

            rowHeader = table.AddRow();
            rowHeader.Cells[0].Shading.Color = Color.Empty;
            rowHeader.Cells[0].AddParagraph("0532 167 57 79");
            //rowHeader.Borders.Bottom.Color = Colors.Red;

            rowHeader = table.AddRow();
            rowHeader.Cells[0].Shading.Color = Color.Empty;
            rowHeader.Cells[0].AddParagraph("cihan.karali@karalicay.com");
            //rowHeader.Borders.Bottom.Color = Colors.Red;
            #endregion

            #region Fatura & Sipariş Bilgileri
            table = section.AddTable();
            table.Style = "Table";

            Column columnHeaderSub;
            columnHeaderSub = table.AddColumn(Unit.FromCentimeter(8));
            columnHeaderSub.Format.Alignment = ParagraphAlignment.Left;
            columnHeaderSub = table.AddColumn(Unit.FromCentimeter(7));
            columnHeaderSub.Format.Alignment = ParagraphAlignment.Left;
            columnHeaderSub = table.AddColumn(Unit.FromCentimeter(2));
            columnHeaderSub.Format.Alignment = ParagraphAlignment.Left;

            Row rowHeaderSub = table.AddRow();

            rowHeaderSub.BottomPadding = 7;
            //rowHeaderSub.TopPadding = 15;

            rowHeaderSub.Cells[0].AddParagraph("Fatura Bilgileri");
            rowHeaderSub.Cells[0].Format.Font.Color = Color.FromRgb(158, 161, 163);
            rowHeaderSub.Cells[0].Format.Font.Bold = true;
            rowHeaderSub.Cells[0].Format.Alignment = ParagraphAlignment.Left;
            rowHeaderSub.Cells[0].VerticalAlignment = VerticalAlignment.Center;

            rowHeaderSub.BottomPadding = 7;
            rowHeaderSub.Cells[1].AddParagraph("Sipariş Bilgileri");
            rowHeaderSub.Cells[1].Format.Font.Color = Color.FromRgb(158, 161, 163);
            rowHeaderSub.Cells[1].Format.Font.Bold = true;
            rowHeaderSub.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            rowHeaderSub.Cells[1].VerticalAlignment = VerticalAlignment.Center;

            rowHeaderSub = table.AddRow();
            rowHeaderSub.BottomPadding = 5;

            rowHeaderSub.Cells[0].AddParagraph("Onur Çalışkan");
            rowHeaderSub.Cells[0].Format.Font.Bold = true;

            rowHeaderSub.Cells[1].AddParagraph("Sipariş Numarası:");
            rowHeaderSub.Cells[1].Borders.Bottom.Color = Color.FromRgb(242, 245, 247);

            rowHeaderSub.Cells[2].AddParagraph("123456789");
            rowHeaderSub.Cells[2].Borders.Bottom.Color = Color.FromRgb(242, 245, 247);

            rowHeaderSub = table.AddRow();
            rowHeaderSub.BottomPadding = 5;
            rowHeaderSub.TopPadding = 5;

            rowHeaderSub.Cells[0].AddParagraph("Yıldız Teknik Üniversitesi Davutpaşa Kampüsü Teknopark Ofisi A1 Blok No: 1B48 34220 Esenler, İstanbul \n324 445 - 4544");
            rowHeaderSub.Cells[0].MergeDown = 2;

            rowHeaderSub.Cells[1].AddParagraph("Sipariş Tarihi: ");
            rowHeaderSub.Cells[1].Borders.Bottom.Color = Color.FromRgb(242, 245, 247);

            rowHeaderSub.Cells[2].AddParagraph("19.12.2019");
            rowHeaderSub.Cells[2].Borders.Bottom.Color = Color.FromRgb(242, 245, 247);

            rowHeaderSub = table.AddRow();
            rowHeaderSub.BottomPadding = 5;
            rowHeaderSub.TopPadding = 5;

            rowHeaderSub.Cells[1].AddParagraph("Sipariş Tutarı: ");
            rowHeaderSub.Cells[1].Borders.Bottom.Color = Color.FromRgb(242, 245, 247);

            rowHeaderSub.Cells[2].AddParagraph("800 TL");
            rowHeaderSub.Cells[2].Borders.Bottom.Color = Color.FromRgb(242, 245, 247);

            rowHeaderSub = table.AddRow();
            rowHeaderSub = table.AddRow();
            rowHeaderSub.BottomPadding = 30;

            rowHeaderSub.Cells[0].AddParagraph("onur.caliskan@ekmob.com");

            rowHeaderSub.Cells[1].AddParagraph("");

            rowHeaderSub.Cells[2].AddParagraph("");

            rowHeaderSub = table.AddRow();

            #endregion

            #region View içeriğinin basılacağı Table ve öğelerinin üretimi

            table = section.AddTable();
            table.Style = "Table";
            table.Borders.Color = Color.FromRgb(235, 240, 236);
            table.Borders.Width = 0.25;
            table.Borders.Left.Width = 0;
            table.Borders.Right.Width = 0;
            table.Rows.LeftIndent = 0;

            Column column;
            foreach (DataColumn col in dataTable.Columns)
            {
                column = table.AddColumn(Unit.FromCentimeter(2.8));
                column.Format.Alignment = ParagraphAlignment.Left;
            }

            // Tablonun Header kısmı üretiliyor 
            Row row = table.AddRow();
            row.TopPadding = 7;
            row.BottomPadding = 7;
            //row.HeadingFormat = true;
            //row.Format.Alignment = ParagraphAlignment.Center;
            //row.Format.Font.Bold = true;
            //row.Borders.Left.Width = 0;
            //row.Borders.Right.Width = 0;
            //row.Format.Shading.Color = Colors.Blue;
            //row.Borders.Color = Colors.Orange;


            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                row.Cells[i].AddParagraph(dataTable.Columns[i].ColumnName);
                row.Cells[i].Format.Font.Color = Colors.Black;
                //row.Cells[i].Format.Shading.Color = Colors.Red;
                row.Cells[i].Format.Font.Bold = true;
                row.Cells[i].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[i].VerticalAlignment = VerticalAlignment.Center;
            }

            table.SetEdge(0, 0, dataTable.Columns.Count, 1, Edge.Box, BorderStyle.Single, 0.75, Color.FromRgb(235, 240, 236));

            #endregion View içeriğinin basılacağı Table ve öğelerinin üretimi 

            #region Footer kısmı
            Paragraph paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddLineBreak();
            paragraph.Format.SpaceBefore = "-0.5cm";


            paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText("Sipariş Formu - Ekmob tarafından üretilmiştir. - www.ekmob.com");
            paragraph.Format.Font.Size = 10;
            paragraph.Format.Font.Color = Colors.LightGray;
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddPageField();
            paragraph.Format.Font.Size = 10;
            paragraph.Format.Font.Color = Colors.LightGray;
            paragraph.Format.Alignment = ParagraphAlignment.Right;

            #endregion
        }

        public void KAYDET(String filePath)
        {
            try
            {
            }
            catch (Exception ex)
            {
            }
        }
    }
}
