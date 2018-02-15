using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_KolokwiumA1
{
    abstract class ProjektDomu
    {
        public Dom dom;
        
        public void NowyDom()
        {
            dom = new Dom();
        }

        public virtual void WstawOkna(string rodzajOkien)
        {
            dom.WstawOkna(rodzajOkien);
        }

        public virtual void ZamontujDrzwi(string rodzajDrzwi)
        {
            dom.ZamontujDrzwi(rodzajDrzwi);
        }

        abstract public void PomalujElewacje(Kolor kolor);

        public override string ToString()
        {
           return dom.ToString();
        }
    }
}
