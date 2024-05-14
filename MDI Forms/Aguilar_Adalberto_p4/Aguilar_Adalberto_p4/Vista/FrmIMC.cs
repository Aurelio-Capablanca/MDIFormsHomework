using Aguilar_Adalberto_p4.Controlador.IMCControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aguilar_Adalberto_p4.Vista.IMCVista
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            IMCCalculo calcular = new IMCCalculo();
            Double calculo = calcular.Calcular(mtbPeso.Text, Convert.ToString(nudAltura.Value));
            lblIMC.Text = calculo.ToString("0.00");
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            mtbPeso.Clear();
            nudAltura.Value = 1;
            lblIMC.Text = "0";
        }
    }
}
