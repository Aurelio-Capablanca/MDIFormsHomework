﻿using Aguilar_Adalberto_p4.Vista.IMCVista;
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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formulaIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calcularIMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIMC imc = new FrmIMC();
            imc.Show();
                
        }

        private void formulaLoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLorentz lorentz = new FrmLorentz();
            lorentz.Show();
        }

        private void formulaVanDerWaelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWanDerVael wanDerVael = new FrmWanDerVael();
            wanDerVael.Show();
        }

        private void formulaMLICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMLIC mLIC = new FrmMLIC();
            mLIC.Show();
        }

        private void valoresDeConversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConversiones convertir = new FrmConversiones();
            convertir.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void valoresDeConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformacion informacion = new FrmInformacion();
            informacion.Show();
        }
    }
}
