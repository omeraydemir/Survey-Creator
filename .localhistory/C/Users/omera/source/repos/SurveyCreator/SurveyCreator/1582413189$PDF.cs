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
        public PDF(ANKET anket)
        {
            ANKET = anket;
        }

        public void OLUSTUR()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
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
