using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades.Vehículos
{
    public class Camion : Vehiculo
    {
        public int Carga { get; set; }
        public bool Activo { get; set; }
        public Remolque Remolque { get; set; }
        
        public Camion(int ruedas, string modelo, int carga, bool activo, Remolque remolque) : base(ruedas, modelo) 
        {
        
            Carga= carga;
            Activo= activo;
            Remolque= remolque;
        
        }

        public virtual string QuitarRemolque() 
        {
            Remolque = null;
            return "Se ha desvinculado el Remolque";
        }

        public override string Acelerar()
        {
            return base.Acelerar() + "\nEl Camión acelero a una velocidad de 5m/s";
        }

        public override string Frenar()
        {
            return base.Frenar() + "\nEl Camión freno con las ruedas delanteras";
        }
        public override string Imprimir()
        {
            return base.Imprimir() + "Camión posee: " + $"\nCarga: {Carga}" + $"\nActivo: {Activo}" + $"\nRemolque: {Remolque}";
        }


    }
}
