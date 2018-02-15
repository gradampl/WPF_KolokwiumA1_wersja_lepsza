using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_KolokwiumA1
{
    class Biurowiec:ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(kolor);
        }

        public override void ZamontujDrzwi(string rodzajDrzwi)
        {
            dom.ZamontujDrzwi("szklane");
        }

        public override string ToString()
        {
            string napis = "Biurowiec: ";
            napis += dom.ToString();
            return napis;
        }
    }
}
