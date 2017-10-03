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
        private Asesor[] Asesores = new Asesor[8];
        private Ley[] LeyesEnAlquiler = new Ley[50];


        public Parlamentario(string _Name, int _Age, string _Sex, string _Password)
        {
            Name = _Name;
            Age = _Age;
            Sex = _Sex;
            Password = _Password;
        }

        public string ReturnName()
        {
            return Name;
        }

        public string ReturnPassword()
        {
            return Password;
        }

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

    }
}
