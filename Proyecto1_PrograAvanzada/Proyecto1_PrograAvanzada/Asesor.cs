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
        private Ley[] LeyesEnAlquiler = new Ley[50];


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
        //sacar las leyes
        public void SaveData(int _Age, string _Sex, string _Password)
        {
            Age = _Age;
            Sex = _Sex;
            Password = _Password;
        }

    }
}