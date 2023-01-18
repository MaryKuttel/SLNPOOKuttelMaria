using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades.Vehículos
{
    public class AutoElectrico : Vehiculo
    {

        public string Color { get; set;  }
        public string ModeloBateria { get; set; }


        public AutoElectrico(int ruedas, string modelo,string color, string modeloBateria) : base(ruedas, modelo)
        {
            Color = color;
            ModeloBateria = modeloBateria;
        }


        public override string Acelerar()
        {
            return base.Acelerar() + "\nEl Auto Electrico acelero a una velocidad de 10m/s";
        }

        public override string Frenar()
        {
            return base.Frenar() + "\nEl Auto Electrico freno con las ruedas traseras";
        }

        public override string Imprimir()
        {
            return base.Imprimir() + "Auto Electrico posee: " + $"\nColor: {Color}" + $"\nModelo de Bateria: {ModeloBateria}";
        }

    }
}
