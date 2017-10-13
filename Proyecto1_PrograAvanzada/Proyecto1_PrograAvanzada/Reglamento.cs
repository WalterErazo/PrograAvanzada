using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_PrograAvanzada
{
    class Reglamento
    {
        private string Name;
        private string Description;
        public int Copies = 5;

        public Reglamento(string _Name, string _Description)
        {
            Name = _Name;
            Description = _Description;
        }//Constructor de la clase
        public string returnName()
        {
            return Name;
        }//Devuelve el nombre de la ley
        public string returnDescription()
        {
            return Description;
        }//Devuelve la descripcion

        public void DeleteThisRegulation()
        {
            //falta que se regresen los prestados
            Name = null;
            Description = null;
        }//Incompleto
    }
}
