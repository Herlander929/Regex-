
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
using AutoMan;

namespace AutoMan
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }
        public bool Ok;
        public string Value;
        private void button1_Click(object sender, EventArgs e)
        {
            Ok = true;
            Value = textBox1.Text;
            this.Close();
        }

        public static string Show(string title, string msg, string valor) {
            
            
            InputBox ib = new InputBox();
          //  AutoMan.InpuxBox.sho
            ib.Text = title;
            ib.label1.Text = msg;
            ib.textBox1.Text = valor;
            ib.ShowDialog();

            if (ib.Ok)
            {
                return ib.Value;
            }
            else {
                return "";
                //throw new Exception("Cancelado pelo usuário");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ok = false;
            Value = "";
            Close();
        }
    }
}