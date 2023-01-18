using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades.Vehículos
{
    public class Vehiculo
    {

        public int Ruedas { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(int ruedas, string modelo)
        {
            Ruedas = ruedas;
            Modelo = modelo;

        }

        public virtual string Acelerar()
        {
            return "El Vehículo ha acelerado.";
        }

        public virtual string Frenar()
        {
            return "El vehículo ha frenado.";
        }

        public virtual string Imprimir()
        {
            return "El vehículo ";
        }

    }
}
