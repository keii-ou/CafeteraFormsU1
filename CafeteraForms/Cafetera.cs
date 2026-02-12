using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteraForms
{
    public class Cafetera
    {
        public bool Encendida { get; private set; }
        public int CantidadCafe { get; private set; }   

        public int CapacidadMax { get; private set; }   

        public Cafetera (int capacidad)
        {
            CapacidadMax = capacidad;
            CantidadCafe = capacidad;
            Encendida = false;
        }
        
        public void AlternarEncendido() => Encendida = !Encendida;

        public void Servir()
        {
            if (CantidadCafe > 0)
            {

                CantidadCafe--;
            }
        }

        public void Rellenar()
        {
            CantidadCafe = CapacidadMax;
        }
    }
}
