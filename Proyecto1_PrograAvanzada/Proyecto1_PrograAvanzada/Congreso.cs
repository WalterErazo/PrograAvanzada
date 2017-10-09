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
            A.InicializarAsesores();
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
                        if (Congress[i].SearchPasswordOfAdvisor(nname) != "PasswordNotFound")
                        {
                            return Congress[i].SearchPasswordOfAdvisor(nname);
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
        public Asesor SAsesor(string nname)//malo
        {
            for (int i = 0; i <= cont; i++)
            {
                if (nname == Congress[i].SearchAdvisors(nname).ReturnName())//en un parlamentario busca en sus asesors un nombre que coinsida
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
        public void InicializarCongreso()
        {
            for (int i = 0; i < 100; i++)
            {
                Congress[i] = new Parlamentario("", 0, "", "");
            }
        }
        public Parlamentario getParlamentarioConUnAsesor(string AsName)
        {
            for (int i = 0; i < 100; i++)
            {
                if (Congress[i].SearchAdvisors(AsName).ReturnName() == AsName)
                {
                    return Congress[i];
                }
            }
            return Congress[99];
        }
    }
}