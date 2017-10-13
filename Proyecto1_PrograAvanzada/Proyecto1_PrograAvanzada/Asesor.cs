using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_PrograAvanzada
{
    class Asesor
    {
        private string Name;
        private int Age;
        private string Sex;
        private string Password;
        public bool CanEdit = false;
        public Ley[] LeyesEnAlquiler = new Ley[0];
        public Reglamento[] ReglamentosEnAlquiler = new Reglamento[0];


        public Asesor(string _Name, int _Age, string _Sex, string _Password)
        {
            Name = _Name;
            Age = _Age;
            Sex = _Sex;
            Password = _Password;
        }//Constructor
        public string ReturnName()
        {
            return Name;
        }//Regresa el nombre
        public string ReturnPassword()
        {
            return Password;
        }//Regresa la contraseña
        public int ReturnAge()
        {
            return Age;
        }//Regresa la edad
        public string ReturnSex()
        {
            return Sex;
        }//Regresa el sexo
        public void Remove()
        {
            Name = "";
            Age = 0;
            Sex = "";
            Password = "";
        }//Borra la Informacion de un Asesor


        //Laws
        public void AlquilarLey(Ley A)
        {
            Array.Resize(ref LeyesEnAlquiler, (LeyesEnAlquiler.Length + 1));
            LeyesEnAlquiler[LeyesEnAlquiler.Length - 1] = A;
        }//Agranda el arreglo 1 tamaño y guarda la nueva
        public void DevolverLey(Ley A)
        {
            for (int i = 0; i < LeyesEnAlquiler.Length; i++)
            {
                if (A.returnName() == LeyesEnAlquiler[i].returnName())
                {
                    LeyesEnAlquiler[i] = null;
                }
            }
            this.ArreglarLeyes();
        }//Elimina la ley alquilada
        public void ArreglarLeyes()
        {
            int cont = 0;
            for (int i = 0; i < LeyesEnAlquiler.Length; i++)
            {
                if (LeyesEnAlquiler[i] == null)
                {
                    for (int j = cont; j < (LeyesEnAlquiler.Length - 1); j++)
                    {
                        LeyesEnAlquiler[i] = LeyesEnAlquiler[i + 1];
                    }
                }
                else
                {
                    cont++;
                }
            }
            Array.Resize(ref LeyesEnAlquiler, (LeyesEnAlquiler.Length - 1));
        }//Arregla el arreglo xd, para sacar el null y quitar el ultimo porque se repite
        public bool Yalatiene(string S)
        {
            for (int i = 0; i < LeyesEnAlquiler.Length; i++)
            {
                if (S == LeyesEnAlquiler[i].returnName())
                {
                    return true;
                }
            }
            return false;
        }//Verifica si ya tiene la ley


        //reglamento
        public void AlquilarReglamento(Reglamento A)
        {
            Array.Resize(ref ReglamentosEnAlquiler, (ReglamentosEnAlquiler.Length + 1));
            ReglamentosEnAlquiler[ReglamentosEnAlquiler.Length - 1] = A;
        }//Agranda el arreglo 1 tamaño y guarda la nueva 
        public void DevolverReglamento(Reglamento A)
        {
            for (int i = 0; i < ReglamentosEnAlquiler.Length; i++)
            {
                if (A.returnName() == ReglamentosEnAlquiler[i].returnName())
                {
                    ReglamentosEnAlquiler[i] = null;
                }
            }
            this.ArreglarReglamentos();
        }//Elimina la ley alquilada
        public void ArreglarReglamentos()
        {
            int cont = 0;
            for (int i = 0; i < ReglamentosEnAlquiler.Length; i++)
            {
                if (ReglamentosEnAlquiler[i] == null)
                {
                    for (int j = cont; j < (ReglamentosEnAlquiler.Length - 1); j++)
                    {
                        ReglamentosEnAlquiler[i] = ReglamentosEnAlquiler[i + 1];
                    }
                }
                else
                {
                    cont++;
                }
            }
            Array.Resize(ref ReglamentosEnAlquiler, (ReglamentosEnAlquiler.Length - 1));
        }//Arregla el arreglo xd, para sacar el null y quitar el ultimo porque se repite
        public bool YalatieneReg(string S)
        {
            for (int i = 0; i < ReglamentosEnAlquiler.Length; i++)
            {
                if (S == ReglamentosEnAlquiler[i].returnName())
                {
                    return true;
                }
            }
            return false;
        }//Verifica si ya tiene el reglamento
    }
}