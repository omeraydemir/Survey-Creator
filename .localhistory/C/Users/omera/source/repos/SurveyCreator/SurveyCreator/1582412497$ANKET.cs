using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyCreator
{
    class ANKET
    {
        public String AketBasligi { get; set; }
        public String AnketAciklamasi { get; set; }
        public enSayfaYonu SayfaYonu { get; set; }
        public String UstBilgi { get; set; }
        public String AltBilgi { get; set; }
        public Boolean SayfaSayisiGoster { get; set; }
        public SORULAR sorular { get; set; }
        public String filePath { get; set; }
    }

    enum enSayfaYonu
    {
        Yatay=0,
        Dikey=1
    }
}
