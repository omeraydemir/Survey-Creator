using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        public void OLUSTUR()
        {
           
        }

        public DialogResult KAYDET(String filePath)
        {
            try
            {
                return DialogResult.OK;
            }
            catch (Exception ex)
            {
                return DialogResult.Retry;
            }
        }
    }
}
