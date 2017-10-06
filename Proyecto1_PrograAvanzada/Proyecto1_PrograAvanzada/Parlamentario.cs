using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_PrograAvanzada
{
    class Parlamentario
    {
        private string Name;
        private int Age;
        private string Sex;
        private string Password;
        public bool CanEdit = true;
        private Asesor[] Asesores = new Asesor[8];
        private Ley[] LeyesEnAlquiler = new Ley[50];


        public Parlamentario(string _Name, int _Age, string _Sex, string _Password)
        {
            Name = _Name;
            Age = _Age;
            Sex = _Sex;
            Password = _Password;
        }//Constructor
        public string ReturnName()
        {
            return Name;
        }//retorna el nombre
        public string ReturnPassword()
        {
            return Password;
        }//Retorna la contraseña
        public string SearchInAdvisors(string name)
        {
            for (int i = 0; i < 8; i++)
            {
                if (name == Asesores[i].ReturnName())
                {
                    return Asesores[i].ReturnPassword();
                }
            }
            return "PasswordNotFound";
        }
        public Asesor SearchAdvisors(string name)
        {
            for (int i = 0; i < 7; i++)
            {
                if (name == Asesores[i].ReturnName())
                {
                    return Asesores[i];
                }
            }
            return Asesores[7];
        }
        public void AddToAdvisor(Asesor AS)
        {
            for (int i = 0; i < 8; i++)
            {
                if(Asesores[i].ReturnName() == "")
                {
                    Asesores[i] = AS;
                }
            }
        }//Añade un asesor al diputado
        public void RemoveFromAdvisor(Asesor AS)
        {
            for (int i = 0; i < 8; i++)
            {
                if (AS.ReturnName() == Asesores[i].ReturnName())
                {
                    Asesores[i].Remove();
                }
            }
        }///Borra la informacion existente de un asesor
    }
}
