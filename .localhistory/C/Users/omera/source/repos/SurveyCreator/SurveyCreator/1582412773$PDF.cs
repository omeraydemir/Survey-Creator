﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyCreator
{
    class PDF
    {
        ANKET ANKET;
        public  PDF(ANKET anket)
        {
            ANKET = anket;
        }

        public DialogResult KAYDET(String filePath)
        {
            return DialogResult.OKİ;
        }
    }
}
