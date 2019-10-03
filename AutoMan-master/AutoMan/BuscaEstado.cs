
/*
 * por: Gustavo Augusto Hennig
 * 2º sem 2007
 * Direitos Reservados
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoMan
{
    public partial class BuscaEstado : Form
    {
        public bool Ok;
        public bool Excluir;


        public BuscaEstado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Ok = false;
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cmbEstDest.SelectedItem == null)
            {
                MessageBox.Show("Nenhum estado selecionado.");
            }
            else
            {
                Excluir = true;
                Close();
            }
        }

        public void MontaCombo(Automato at)
        {
            foreach (Estado e in at.Estados.Values)
            {
                cmbEstDest.Items.Add(e);
            }
        }

        public void PreSelecionaEstado(Estado e) {
            cmbEstDest.SelectedItem = e;
        }

        public Estado getSelected() {
            return (Estado)cmbEstDest.SelectedItem;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbEstDest.SelectedItem == null) { 
            MessageBox.Show("Nenhum estado selecionado.");
            }else{
            Ok = true;
            Close();
        }
        }
    }
}