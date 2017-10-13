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
        }//Retorna la Ley cuando se conoce su posicion
        public int ReturnNumberOfLaw(string A)
        {
            for (int i = 0; i < GoathemalaLaws.Length; i++)
            {
                if (GoathemalaLaws[i].returnName() == A)
                {
                    return i;
                }
            }
            return -1;
        }//retorna la posicion de la ley en el arreglo oficial
        public void rentLaws(string _name, ref Ley A)
        {
            for (int i = 0; i < GoathemalaLaws.Length; i++)
            {
                if ((_name == GoathemalaLaws[i].returnName()))
                {
                    if ((GoathemalaLaws[i].Copies > 0))
                    {
                        GoathemalaLaws[i].Copies--;
                        A = GoathemalaLaws[i];
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Lo sentimos, actualmente no hay copias disponibles");
                    }
                }
            }
        }//Busca la ley para prestarla
        public void returnLaws(string _name, ref Ley A)
        {
            for (int i = 0; i < GoathemalaLaws.Length; i++)
            {
                if ((_name == GoathemalaLaws[i].returnName()) && (GoathemalaLaws[i].Copies > 0))
                {
                    GoathemalaLaws[i].Copies++;
                    A = GoathemalaLaws[i];
                }
            }
        }//Busca la ley para retornarla
        public void DeleteLaw(string Lawname)
        {
            Ley tempLey = new Ley("", "");
            this.rentLaws(Lawname, ref tempLey);//Para poder convertir el nombre al objeto ley
            //ciclo para que todos los parlamentarios que tienen la ley la regresen antes de eliminarla
            for (int i = 0; i < Congress.Length; i++)
            {
                //Ciclo para que en un parlamentario se busque si tiene la ley
                for (int j = 0; j < Congress[i].LeyesEnAlquiler.Length; j++)
                {
                    //si alguna de sus leyes coincide con el nombre, se devuelve
                    if (Lawname == Congress[i].LeyesEnAlquiler[j].returnName())
                    {
                        Congress[i].DevolverLey(tempLey);
                    }
                }
                //este ciclo es para buscar en los asesores a ver si alguno la tiene
                for (int k = 0; k < 8; k++)
                {
                    //entra al parlamentario donde estan los asesores, entra a los asesores donde estan
                    //sus leyes prestadas, entra a las leyes para comparar...
                    for (int j = 0; j < Congress[i].Asesores[k].LeyesEnAlquiler.Length; j++)
                    {
                        if (Lawname == Congress[i].Asesores[k].LeyesEnAlquiler[j].returnName())
                        {
                            Congress[i].Asesores[k].DevolverLey(tempLey);
                        }
                    }
                }
                tempLey = null;
                GoathemalaLaws[ReturnNumberOfLaw(Lawname)] = null;
                this.ArreglarLeyes();
            }
        }
        public void ArreglarLeyes()
        {
            int cont = 0;
            for (int i = 0; i < GoathemalaLaws.Length; i++)
            {
                if (GoathemalaLaws[i] == null)
                {
                    for (int j = cont; j < (GoathemalaLaws.Length - 1); j++)
                    {
                        GoathemalaLaws[i] = GoathemalaLaws[i + 1];
                    }
                }
                else
                {
                    cont++;
                }
            }
            Array.Resize(ref GoathemalaLaws, (GoathemalaLaws.Length - 1));
        }//Arregla el arreglo xd, para sacar el null y quitar el ultimo porque se repite


        //Regulations
        public string SearchAssociatedLaw(string _NameR)
        {
            for (int i = 0; i < GoathemalaLaws.Length; i++)
            {
                for (int j = 0; j < GoathemalaLaws[i].Reglamentos.Length; j++)
                {
                    if (GoathemalaLaws[i].Reglamentos[j].returnName() == _NameR)
                    {
                        return GoathemalaLaws[i].returnName();
                    }
                }
            }
            //solo para retornar algo
            return "-1";
        }//Busca el nombre de la ley asociada cuando solo se tiene el reglamento
        public void rentRegulation(string _name, ref Reglamento A)
        {
            for (int i = 0; i < this.GoathemalaLaws.Length; i++)
            {
                for (int j = 0; j < this.GoathemalaLaws[i].Reglamentos.Length; j++)
                {
                    if ((_name == GoathemalaLaws[i].Reglamentos[j].returnName()))
                    {
                        if ((GoathemalaLaws[i].Reglamentos[j].Copies > 0))
                        {
                            GoathemalaLaws[i].Reglamentos[j].Copies--;
                            A = GoathemalaLaws[i].Reglamentos[j];
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Lo sentimos, actualmente no hay copias disponibles");
                        }
                    }
                }
            }
        }
        public void returnRegulation(string _name, ref Reglamento A)
        {
            for (int i = 0; i < this.GoathemalaLaws.Length; i++)
            {
                for (int j = 0; j < this.GoathemalaLaws[i].Reglamentos.Length; j++)
                {
                    if ((_name == this.GoathemalaLaws[i].Reglamentos[j].returnName()) && (this.GoathemalaLaws[i].Reglamentos[j].Copies > 0))
                    {
                        this.GoathemalaLaws[i].Reglamentos[j].Copies++;
                        A = GoathemalaLaws[i].Reglamentos[j];
                    }
                }
            }//Busca la ley para retornarla
        }

        public void DeleteReg(string Regname)
        {
            Reglamento tempReg = new Reglamento("", "");
            this.rentRegulation(Regname, ref tempReg);//Para poder convertir el nombre al objeto ley
            //ciclo para que todos los parlamentarios que tienen la ley la regresen antes de eliminarla
            for (int i = 0; i < Congress.Length; i++)
            {
                //Ciclo para que en un parlamentario se busque si tiene la ley
                for (int j = 0; j < Congress[i].ReglamentosEnAlquiler.Length; j++)
                {
                    //si alguna de sus leyes coincide con el nombre, se devuelve
                    if (Regname == Congress[i].ReglamentosEnAlquiler[j].returnName())
                    {
                        Congress[i].DevolverReglamento(tempReg);
                    }
                }
                //este ciclo es para buscar en los asesores a ver si alguno la tiene
                for (int k = 0; k < 8; k++)
                {
                    //entra al parlamentario donde estan los asesores, entra a los asesores donde estan
                    //sus leyes prestadas, entra a las leyes para comparar...
                    for (int j = 0; j < Congress[i].Asesores[k].ReglamentosEnAlquiler.Length; j++)
                    {
                        if (Regname == Congress[i].Asesores[k].ReglamentosEnAlquiler[j].returnName())
                        {
                            Congress[i].Asesores[k].DevolverReglamento(tempReg);
                        }
                    }
                }
                tempReg = null;

                for (int k = 0; k < this.GoathemalaLaws.Length; k++)
                {
                    for (int j = 0; j < this.GoathemalaLaws[i].Reglamentos.Length; j++)
                    {
                        if (GoathemalaLaws[i].Reglamentos[j].returnName() == Regname)
                        {
                            GoathemalaLaws[i].Reglamentos[j] = null;
                        }
                    }
                }
            }
            this.ArreglarReg();
        }
        //Se supone que automaticamente detecta el null 
        public void ArreglarReg()
        {
            int cont = 0;
            for (int i = 0; i < this.GoathemalaLaws.Length; i++)
            {
                for (int j = 0; j < this.GoathemalaLaws[i].Reglamentos.Length; j++)
                {
                    if (GoathemalaLaws[i].Reglamentos[j] == null)
                    {
                        for (int k = cont; k < (GoathemalaLaws[i].Reglamentos.Length - 1); k++)
                        {
                            GoathemalaLaws[i].Reglamentos[k] = GoathemalaLaws[i].Reglamentos[k + 1];
                        }
                    }
                    else
                    {
                        cont++;
                    }
                }
                Array.Resize(ref GoathemalaLaws[i].Reglamentos, (GoathemalaLaws[i].Reglamentos.Length - 1));
            }
        }//Arregla el arreglo xd, para sacar el null y quitar el ultimo porque se repite

    }
}