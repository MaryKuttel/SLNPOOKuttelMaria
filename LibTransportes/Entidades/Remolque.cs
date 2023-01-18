using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Remolque
    {
        public int Peso { get; set; }
        public bool Conectado { get; set; }


        public Remolque(int peso, bool conectado)
        {
            Peso = peso;
            Conectado = conectado;
        
        }

        public virtual string ImprimirRemolque()
        {
            return $"El Remolque soporta {Peso} de Peso y actualmente  esta/no esta Conectado({Conectado})";
        }

    }
}
