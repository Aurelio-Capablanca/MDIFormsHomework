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
    public partial class FrmWanDerVael : Form
    {
        public FrmWanDerVael()
        {
            InitializeComponent();
            cmbGenero.DataSource = FuncionesGenerales.LlenarComboBoxGenero();
            cmbGenero.DisplayMember = "miembro";
            cmbGenero.ValueMember = "valor";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LorentzWanDerVaelControlador controlar = new LorentzWanDerVaelControlador();
            Double resultado = controlar.CalcularWanDerVael(cmbGenero.SelectedValue.ToString(), mtxtAltura.Text);
            lblResultado.Text = resultado.ToString("0.00");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbGenero.SelectedValue = "0";
            mtxtAltura.Value = 1;
            lblResultado.Text = "0";
        }
    }
}
