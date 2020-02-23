using System;
using System.Collections.Generic;

namespace SurveyCreator
{
    class SORULAR
    {
        public String SoruBasligi { get; set; }
        public String SoruAciklamasi { get; set; }
        public SoruTipleri SoruTipi { get; set; }
        public List<String> Secenekler { get; set; }
        public List<String> PuanBasliklari { get; set; }
    }
    enum SoruTipleri{
        KısaMetin=0,
        UzunMetin=1,
        Secenekli=2,
        Puanli=3
    }
}
