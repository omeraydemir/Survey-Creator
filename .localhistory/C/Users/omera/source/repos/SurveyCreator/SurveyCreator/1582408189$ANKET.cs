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
        public int SayfaYonu { get; set; }
        public String UstBilgi { get; set; }
    }

    enum SayfaYonu
    {
        Yatay=0,
        Dikey=1
    }
}
