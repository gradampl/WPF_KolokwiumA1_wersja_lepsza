using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wpf_KolokwiumA1
{
    class Dom
    {
        string drzwi;
        Kolor kolorElewacji;
        string okno;

        public void WstawOkna(string okno)
        {
            this.okno = okno;
        }

        public void ZamontujDrzwi(string drzwi)
        {
            this.drzwi = drzwi;
        }

        public void PomalujElewacje(Kolor kolor)
        {
            kolorElewacji = kolor;
        }

        public override string ToString()
        {
            bool czyPuste = (string.IsNullOrEmpty(okno) || string.IsNullOrEmpty(drzwi));
            if (czyPuste)
            {
                return "Kolor elewacji: " + kolorElewacji;
            }
            else
                return "Okna: " + okno + ", Drzwi: " + drzwi + ", Kolor elewacji: " + kolorElewacji;
        }
        
    }
}
    

