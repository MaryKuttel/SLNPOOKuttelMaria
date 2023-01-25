using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades.Vehiculos
{
    public abstract class Vehiculo
    {

        public int Ruedas { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(int ruedas, string modelo)
        {
            Ruedas = ruedas;
            Modelo = modelo;

        }

        public abstract string Acelerar();

        public abstract string Frenar();

        public virtual string Imprimir()
        {
            return "El vehículo ";
        }

    }
}
