using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_PrograAvanzada
{
    class Congreso
    {
        public Parlamentario[] Congress = new Parlamentario[0];
        public Ley[] GoathemalaLaws = new Ley[0];

        private int cont = 0;


        //Users
        public void addParlamentario(Parlamentario A)
        {
            Array.Resize(ref Congress, Congress.Length + 1);
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
        public int AsociarAParlamentario(string ParName, Asesor AS)
        {
            for (int i = 0; i <= cont; i++)
            {
                if (ParName == Congress[i].ReturnName())//Busca al parlamentario
                {
                    Congress[i].AddToAdvisor(AS);
                    return 0;//Retorna 0 si se logro asignar correctamente
                }
            }
            return -1;//Retrona menos 1 si no hay ningun parlamentario llamado asi
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



        //Laws
        public void addLaw(Ley _NewLey)
        {
            Array.Resize(ref GoathemalaLaws, (GoathemalaLaws.Length + 1));
            GoathemalaLaws[GoathemalaLaws.Length - 1] = _NewLey;
        }//Añade una nueva ley en el congreso
        public Ley returnLaws(int i)
        {
            return GoathemalaLaws[i];
        }//Retorna la Ley del arreglo indicada
    }
}