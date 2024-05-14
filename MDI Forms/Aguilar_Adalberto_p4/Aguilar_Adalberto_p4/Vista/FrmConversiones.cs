using Aguilar_Adalberto_p4.Componentes;
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
    public partial class FrmConversiones : Form
    {
        public FrmConversiones()
        {
            InitializeComponent();
            cmbCategoria.DataSource = FuncionesGenerales.LlenarComboBoxConversiones();
            cmbCategoria.DisplayMember = "miembro";
            cmbCategoria.ValueMember = "valor";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ConversionesControlador controlador = new ConversionesControlador();
            double resultado = controlador.Calcular(cmbCategoria.SelectedIndex.ToString(), mtxtEntrada.Text);
            lblResultado.Text = resultado.ToString("000.00");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbCategoria.SelectedValue = "0";
            lblResultado.Text = "0";
            mtxtEntrada.Value = 1;
        }
    }
}
