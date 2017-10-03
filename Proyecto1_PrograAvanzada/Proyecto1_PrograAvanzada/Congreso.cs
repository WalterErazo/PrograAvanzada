using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_PrograAvanzada
{
    class Congreso
    {
        public Parlamentario[] Congress = new Parlamentario[100];
        private int cont = 0;

        public void addParlamentario(Parlamentario A)
        {
            Congress[cont] = A;
            cont++;
        }


        public string BuscarUsuario(string nname)
        {
            for (int i = 0; i <= cont; i++)
            {
                if (nname == Congress[i].ReturnName())//Busca al parlamentario
                {
                    return Congress[i].ReturnPassword();
                }
                else//busca algun asesor
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Congress[i].SearchInAdvisors(nname);
                    }
                }
            }
            return "PasswordNotFound";
        }


    }
}
