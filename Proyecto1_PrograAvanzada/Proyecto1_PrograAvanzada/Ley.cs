﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_PrograAvanzada
{
    class Ley
    {
        private string Name;
        private string Description;
        public int Copies = 5;
        public Reglamento[] Reglamentos = new Reglamento[0];

        public Ley (string _Name, string _Description)
        {
            Name = _Name;
            Description = _Description;
        }//Constructor de la clase
        public void AddRegulation(Reglamento NewRegulation)
        {
            int LastPosition = Reglamentos.Length;
            Array.Resize(ref Reglamentos, (Reglamentos.Length + 1));
            Reglamentos[LastPosition] = NewRegulation;
        }//Añade un nuevo reglamento
        public string returnName()
        {
            return Name;
        }//Devuelve el nombre de la ley
        public string returnDescription()
        {
            return Description;
        }//Devuelve la descripcion



        public void BorrarReglamentosAsociadosALey()
        {       
            while (Reglamentos.Length >= 1)
            {
                Reglamentos[(Reglamentos.Length - 1)].DeleteThisRegulation();//borra los reglamentos que esten asociados con esta ley
                Array.Sort(Reglamentos);
                Array.Resize(ref Reglamentos, (Reglamentos.Length - 1));
            }

            Name = null ;
            Description = null;
        }//Incompleto
    }
}
