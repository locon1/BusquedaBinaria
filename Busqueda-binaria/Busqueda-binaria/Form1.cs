using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busqueda_binaria
{
    public partial class Form1 : Form
    {
        Vector vector;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            vector = new Vector(Convert.ToInt32(txtSize.Text));
        }

        private void cmdLlenar_Click(object sender, EventArgs e)
        {
            vector.llenarVector(Convert.ToInt32(txtLimit.Text));
        }

        private void cmdOrdenar_Click(object sender, EventArgs e)
        {
            vector.ordenar();
        }

        private void cmdVer_Click(object sender, EventArgs e)
        {
            txtRes.Text = vector.mostrar();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            int busqueda = vector.busquedaBinaria(Convert.ToInt32(txtSearch.Text));

            if (busqueda == -1)
                lblResult.Text = "-1";
            else
                lblResult.Text = "El numero esta en la posicion: " + busqueda;
        }
    }
}
