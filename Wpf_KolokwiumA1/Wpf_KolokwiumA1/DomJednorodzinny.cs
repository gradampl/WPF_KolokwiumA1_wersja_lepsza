using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_KolokwiumA1
{
    class DomJednorodzinny:ProjektDomu
    {
        public override void PomalujElewacje(Kolor kolor)
        {
            dom.PomalujElewacje(Kolor.Czerwony);
        }

        public override string ToString()
        {
            string napis = "Dom jednorodzinny: ";
            napis += dom.ToString();
            return napis;
        }
    }
}
