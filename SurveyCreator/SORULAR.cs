using System;
using System.Collections.Generic;

namespace SurveyCreator
{
    class SORULAR
    {
        public String SoruBasligi { get; set; }
        public String SoruAciklamasi { get; set; }
        public enSoruTipleri SoruTipi { get; set; }
        public List<String> Secenekler { get; set; }
        public List<String> PuanBasliklari { get; set; }
    }
    public enum enSoruTipleri{
        KisaMetin=0,
        UzunMetin=1,
        Secenekli=2,
        Puanli=3
    }
}
