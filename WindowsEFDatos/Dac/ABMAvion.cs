using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos.Dac
{
    public static class ABMAvion
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> Listar()
        {
            return context.Aviones.ToList();
        }

        public static int InsertAvion(Avion avion)
        {
            context.Aviones.Add(avion);
            return context.SaveChanges();
        }


    }
}
