using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEFDatos.Modelos
{
    [Table("LineaAerea")]
    public class LineaAerea
    {

        [Key]
        public int IdLinea { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }


        public DateTime FechaInicioActividad { get; set; }

        public List<Avion> Aviones { get; set; }


        /* public LineaAerea(int idLinea, string nombre, DateTime fechaInicio, List<Avion> aviones)
        {
            IdLinea= idLinea;
            Nombre= nombre;
            FechaInicioActividad= fechaInicio;
            Aviones= aviones;
        }*/



    }
}
