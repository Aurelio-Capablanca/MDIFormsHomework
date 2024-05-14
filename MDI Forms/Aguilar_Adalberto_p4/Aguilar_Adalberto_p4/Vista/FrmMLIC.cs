using Aguilar_Adalberto_p4.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguilar_Adalberto_p4.Vista
{
    public partial class FrmMLIC : Form
    {
        public FrmMLIC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MCLICControlador controlador = new MCLICControlador();
            double resultado = controlador.CalcularMLIC(mtxtAltura.Text);
            lblResultado.Text = resultado.ToString("0.00");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "0";
            mtxtAltura.Clear();
        }
    }
}
