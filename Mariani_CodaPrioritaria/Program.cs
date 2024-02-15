using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_CodaPrioritaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CodaPrioritaria ciao = new CodaPrioritaria();

            ciao.Aggiunta(1);
            ciao.Aggiunta(5);
            ciao.Aggiunta(2);
            ciao.Aggiunta(6);
            ciao.Aggiunta(0);
            ciao.Aggiunta(18);

            ciao.Visualizza();
        }
    }
}
