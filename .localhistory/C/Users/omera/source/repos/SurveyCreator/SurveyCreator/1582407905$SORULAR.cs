﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyCreator
{
    class SORULAR
    {
        public String SoruBasligi { get; set; }
        public String SoruAciklamasi { get; set; }
        public String SoruTipi { get; set; }
    }
    enum SoruTipleri{
        KısaMetin=0,
        UzunMetin=1,
        Secenekli=2,
        Puanli=3
    }
}
