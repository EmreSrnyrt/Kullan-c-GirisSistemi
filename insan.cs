using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class insan
    {
        private string ad;
        private string soyad;
        private ulong tc;
        private byte yas;

        public string Ad
        {
            get { return ad; }
            set
            {
                string toTitleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
                ad = toTitleCase;
            }
        }
        public string Soyad
        {
            get { return soyad; }
            set
            {
                soyad = value.ToUpper();
            }
        }

        public ulong TC
        {
            get { return tc; }
            set
            {
                if (value.ToString().Length != 11)
                {
                    Console.WriteLine("Tc 11 Haneli Olmalı");
                }
                else

                {
                    tc = value;
                }
            }
        }
        public byte Yas
        {
            get { return yas; }
            set { yas = value; }
        }


    }
}
