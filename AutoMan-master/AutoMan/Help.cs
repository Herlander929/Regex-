
/*
 * por: Gustavo Augusto Hennig
 * http://gustavoh.co.cc
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
using System.IO;

namespace AutoMan
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();

            try
            {
                FileInfo f = new FileInfo(Application.ExecutablePath);
                webBrowser1.Url = new Uri(f.DirectoryName + "\\help.html");
            }
            catch (Exception e) {
                MessageBox.Show("Erro o localizar o arquivo de ajuda.\n\n" + e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}