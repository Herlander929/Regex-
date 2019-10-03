
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
    public partial class AlteraTransicao : Form
    {
        public AlteraTransicao()
        {
            InitializeComponent();
        }
        public bool Ok;
        //Transicao transicao;

        private void btnOk_Click(object sender, EventArgs e)
        {
            /*
            if (cmbEstOr.SelectedItem != null)
            {
                transicao = new Transicao(((Estado)cmbEstOr.SelectedItem));
                if (cmbEstDest.SelectedItem != null)
                {
                    transicao.EstadoDestino = (Estado)cmbEstDest.SelectedItem;
                    //transicao.Simbolos.Add(((Simbolo)cmbSimbolo.SelectedItem));
                    transicao.Simbolo=(Simbolo)cmbSimbolo.SelectedItem;
                }

            }
            */
            Ok = true;
            this.Close();

        }
        /*
        public static Transicao getNewTransicao(Automato aut)
        {
            AlteraTransicao at = new AlteraTransicao();
            at.MontaCombos(aut);
            at.ShowDialog();
            return at.transicao;
        }*/

        public void MontaCombos(Automato at)
        {

            foreach (Estado e in at.Estados.Values)
            {
                cmbEstOr.Items.Add(e);
                cmbEstDest.Items.Add(e);
            }
            foreach (Simbolo s in at.Alfabeto.Values)
            {
                cmbSimbolo.Items.Add(s);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
//            transicao = null;
            Ok = false;
            this.Close();
        }


        public static Transicao EditaTransicao(Transicao t, Automato aut)
        {
            AlteraTransicao at = new AlteraTransicao();
            at.MontaCombos(aut);
            if (t != null)
            {
                at.cmbEstOr.SelectedItem = t.EstadoOrigem;
               // at.cmbEstDest.SelectedItem = t.EstadoDestino;
                at.cmbSimbolo.SelectedItem = t.Simbolo;
            }
            
            at.ShowDialog();
            if (at.Ok)
            {
                if (t == null)
                {
                    t = new Transicao();
                }
                
                t.EstadoOrigem = (Estado)at.cmbEstOr.SelectedItem;
               // t.EstadoDestino = (Estado)at.cmbEstDest.SelectedItem;
                t.Simbolo = (Simbolo)at.cmbSimbolo.SelectedItem;
                return t;
            }
            else {
                return null;
            }

            
            
        }
    }
}