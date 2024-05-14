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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aguilar_Adalberto_p4.Vista
{
    public partial class FrmLorentz : Form
    {
        public FrmLorentz()
        {
            InitializeComponent();
            cmbGenero.DataSource = FuncionesGenerales.LlenarComboBoxGenero();
            cmbGenero.DisplayMember = "miembro";
            cmbGenero.ValueMember = "valor";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LorentzWanDerVaelControlador controlar = new LorentzWanDerVaelControlador();
            Double resultado = controlar.CalcularLorentz(cmbGenero.SelectedValue.ToString(), mtxtAltura.Text);
            lblResultado.Text = resultado.ToString("0.00");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbGenero.SelectedValue = "0";
            mtxtAltura.Value = 1;
            lblResultado.Text = "0";

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void mtxtAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
