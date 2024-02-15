using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariani_CodaPrioritaria
{
    internal class CodaPrioritaria
    {
        ArrayList lista = new ArrayList();

        public void Aggiunta(int id)
        {
            if (lista.Count == 0)
            {
                lista.Add(id);
            }
            else 
            {
                lista.Insert(CompareTo(lista, id), id);
            }
        }

        public int CompareTo(ArrayList ciao, int b)
        {
            int indirizzo = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (int.Parse(ciao[i].ToString()) > b)
                {
                    indirizzo = i + 1;
                }
                else if (int.Parse(ciao[i].ToString()) < b)
                {
                    indirizzo = i;
                    break;
                }
            }

            return indirizzo;
        }

        public object LetturaPrimoElemento()
        {
            return lista[0];
        }
    }
}
