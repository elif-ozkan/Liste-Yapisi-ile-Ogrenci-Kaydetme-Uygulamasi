﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_ile_Ögrenci_Kaydetme_Uygulaması
{
    class Karakter
    {
        string ad;
        string soyad;
        string meslek;

        public string ADI
        {
            get { return ad; }
            set { ad = value; } 
        }
        public string Soyad
        {
            get { return soyad; }       
            set { soyad = value; }  
        }
        public string Meslek
        {
            get { return meslek; }
            set
            {
                meslek = value;
            }
        }
    }
}
