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
        }//Añade un parlamentario
        public string BuscarUsuarioP(string nname)
        {
            for (int i = 0; i <= cont; i++)
            {
                if (nname == Congress[i].ReturnName())//Busca al parlamentario
                {
                    return Congress[i].ReturnPassword();
                }
                else//busca algun asesor
                {
                    for (int j = 0; j < cont; j++)
                    {
                        if (Congress[i].SearchInAdvisors(nname) != "PasswordNotFound")
                        {
                            return Congress[i].SearchInAdvisors(nname);
                        }
                    }
                }
            }
            return "PasswordNotFound";
        }//Busca la contraseña del usuario
        public string BuscarUsuarioW(string nname)//Busca el trabajo del usuario
        {
            for (int i = 0; i <= cont; i++)
            {
                if (nname == Congress[i].ReturnName())//Busca al parlamentario
                {
                    return "Parlamentario";
                }
            }
            return "Asesor";
        }
        public Parlamentario SParlamentario(string nname)
        {
            for (int i = 0; i <= cont; i++)
            {
                if (nname == Congress[i].ReturnName())//Busca al parlamentario
                {
                    return Congress[i];
                }
            }
            /*Como ya se valido anteriormente la existencia del usuario se supone que
            nunca se llegara a este segundo return*/
            return Congress[100];
        }//Busca al parlamentario que esta intentando ingresar al sistema
        public Asesor SAsesor(string nname)
        {
            for (int i = 0; i <= cont; i++)
            {
                if (nname == Congress[i].ReturnName())//Busca al parlamentario
                {
                    return Congress[i].SearchAdvisors(nname);
                }
            }
            /*Como ya se valido anteriormente la existencia del usuario se supone que
            nunca se llegara a este segundo return*/
            return Congress[100].SearchAdvisors(nname); ;
        }

        public void AsociarAParlamentario(string ParName, Asesor AS)
        {
            for (int i = 0; i <= cont; i++)
            {
                if (ParName == Congress[i].ReturnName())//Busca al parlamentario
                {
                    Congress[i].AddToAdvisor(AS);
                }
            }
        }
    }
}
