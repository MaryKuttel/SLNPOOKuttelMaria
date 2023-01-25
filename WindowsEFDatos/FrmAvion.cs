using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos
{
    public partial class FrmAvion : Form
    {
        public FrmAvion()
        {
            InitializeComponent();
        }

        private void FrmAvion_Load(object sender, EventArgs e)
        {
            MostrarAviones();
        }

        private void MostrarAviones()
        {
            GridAviones.DataSource = ABMAvion.Listar();
        }

        private void insertarAvion_Click(object sender, EventArgs e)
        {
            LineaAerea lineaAerea = new LineaAerea() { Nombre = "Aerolineas Argentinas", FechaInicioActividad = new DateTime(2023, 05, 05) };
            Avion avion = new Avion() { Capacidad = Convert.ToInt32(intCapacidad.Text), Denominacion = txtDenominacion.Text, LineaAerea = lineaAerea };

            int filasAfectadas = ABMAvion.InsertAvion(avion);
            if(filasAfectadas > 0 )
            {
                MessageBox.Show("Avion Agregado Correctamente");
                MostrarAviones();
            }
        }
    }
}
