
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
    public partial class EditaEstado : Form
    {
        public EditaEstado()
        {
            InitializeComponent();
        }
        public bool Ok;

        private void button1_Click(object sender, EventArgs e)
        {
            Ok = true;
            Close();

        }
    }
}