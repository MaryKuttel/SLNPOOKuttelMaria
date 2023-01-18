using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes.Entidades;
using LibTransportes.Entidades.Vehiculos;

namespace PresentacionVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crearCamion_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque(300, true);
            Camion camion = new Camion(6, "BMW", 200, true, remolque);


            MessageBox.Show("El Camion ha sido creado correctamente.");
            MessageBox.Show(camion.Imprimir());
        }

        private void crearRemolque_Click(object sender, EventArgs e)
        {
            Remolque remolque = new Remolque(300, false);

            MessageBox.Show("El Remolque ha sido creado correctamente.");
            MessageBox.Show(remolque.ImprimirRemolque());
        }
    }
}
