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
        private Ley[] LeyesEnAlquiler = new Ley[50];


        public Asesor(string _Name, int _Age, string _Sex, string _Password)
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
    }
}