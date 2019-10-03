
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

namespace AutoMan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private Automato AutomatoInstanciado = new Automato();
        private int lastRowIdx, lastColumnIdx;

        private void btnAdicionarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                String s = InputBox.Show("Adicionando Estado", "Informe o estado a ser adicionado:", "");
                if (s != "")
                {
                    Estado est = AutomatoInstanciado.AdicionaEstado(s);
                    int pos = dataGridView1.Rows.Add();
                    dataGridView1.Rows[pos].HeaderCell.Value = est.Nome;
                    dataGridView1.Rows[pos].Tag = est.Nome;
                }
            }
            catch (Exception ee)
            {
                ExibeMensagem(ee.Message);
            }
            AtualizaDetalhes();
        }

        private void btnRemoverSimbolo_Click(object sender, EventArgs e)
        {
            try
            {
                String s = InputBox.Show("Removendo símbolo", "Informe o símbolo a ser removido:", "");
                if (s != "")
                {
                    s = s.ToUpper();
                    AutomatoInstanciado.RemoveSimbolo(s);
                    dataGridView1.Columns.Remove(s);
                }
            }
            catch (Exception ee)
            {
                ExibeMensagem(ee.Message);
            }
            RefreshAlfabeto();
        }

        private void btnAdicionarSimbolo_Click(object sender, EventArgs e)
        {
            try
            {
                string s = InputBox.Show("Adicionando símbolo", "Informe o símbolo a ser adicionado (E = Vazio):", "");
                if (s != "")
                {
                    s = s.ToUpper();
                    AutomatoInstanciado.AdicionaSimbolo(s);
                    dataGridView1.Columns.Add(s, s);
                }
            }
            catch (Exception ee)
            {
                ExibeMensagem(ee.Message);
            }
            RefreshAlfabeto();
        }

        public void ExibeMensagem(string msg)
        {
            MessageBox.Show(msg);
        }

        public void RefreshAlfabeto()
        {
            this.lblAlfabetoAtual.Text = AutomatoInstanciado.getAlfabeto();
            AtualizaDetalhes();
        }

        private void btnAticionarTransição_Click(object sender, EventArgs e)
        {

            /*Transicao t = AlteraTransicao.getNewTransicao(AutomatoInstanciado);
            if (t != null) {
                AutomatoInstanciado.AdicionaTransicao(t);
            }
             * */
        }

        private void btnRemoverEstado_Click(object sender, EventArgs e)
        {

            try
            {
                String s = InputBox.Show("Remover Estado", "Informe o estado a ser removido:", "");
                if (s != "")
                {
                    s = s.ToUpper();
                    AutomatoInstanciado.RemoveEstado(s);

                    /*
                    for(int i = 0 ;i<= dataGridView1.Rows.Count;i++){
                        if (s == (string)dataGridView1.Rows[i].HeaderCell.Value)
                        {
                            dataGridView1.Rows.RemoveAt(i);
                            break;
                        }
                
                    }
                    */
                    foreach (DataGridViewRow rr in dataGridView1.Rows)
                    {
                        if (s == (string)rr.Tag)
                        {
                            dataGridView1.Rows.Remove(rr);
                            break;
                        }
                    }

                }

            }
            catch (Exception ee)
            {
                ExibeMensagem(ee.Message);
            }
            AtualizaDetalhes();
        }

        private void btnValidaAutomato_Click(object sender, EventArgs e)
        {
            try
            {
                AutomatoInstanciado.ValidaAutomato();
                MessageBox.Show("Nenhum erro encontrado no autômato.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            AtualizaDetalhes();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                lastRowIdx = e.RowIndex;
                lastColumnIdx = e.ColumnIndex;

                this.tsmEditarTransicao.Visible = e.ColumnIndex != -1;
                contextMenuStrip1.Show(dataGridView1, new Point(e.X + 10, e.Y + 10));
            }
        }

        private void EditaTransicao()
        {
            //  try
            {
                Estado e = getSelectedEstado();
                Transicao tr_ed;

                if (e.Transicoes.ContainsKey(dataGridView1.Columns[lastColumnIdx].Name))
                {
                    tr_ed = e.Transicoes[dataGridView1.Columns[lastColumnIdx].Name];
                }
                else
                {
                    tr_ed = new Transicao(e);
                    tr_ed.Simbolo = AutomatoInstanciado.Alfabeto[dataGridView1.Columns[lastColumnIdx].Name];
                }

                BuscaEstado b = new BuscaEstado();
                b.MontaCombo(AutomatoInstanciado);

                b.ShowDialog();
                if (b.Ok)
                {

                    tr_ed.AddEstadoDest(b.getSelected());
                    e.SyncTransicao(tr_ed);
                }
                else if (b.Excluir)
                {
                    if (tr_ed.EstadosDestino.Contains(b.getSelected()))
                    {
                        tr_ed.EstadosDestino.Remove(b.getSelected());
                    }
                    if (tr_ed.EstadosDestino.Count == 0)
                    {
                        e.Transicoes.Remove(tr_ed.Simbolo.simbolo);
                    }
                }
                AtualizaLastCell();
            }
            //  catch (Exception e)
            {

                //  MessageBox.Show(e.Message);
            }
        }

        private void AtualizaLastCell()
        {

            string s = "";
            Estado e = getSelectedEstado();
            if (e.Transicoes.ContainsKey(dataGridView1.Columns[lastColumnIdx].Name))
            {
                Transicao t = e.Transicoes[dataGridView1.Columns[lastColumnIdx].Name];
                foreach (Estado ee in t.EstadosDestino)
                {
                    s += ee.Nome + ", ";
                }
            }
            if (s != "")
            {
                s = s.Substring(0, s.Length - 2);
            }

            dataGridView1.Rows[lastRowIdx].Cells[lastColumnIdx].Value = s;
            AtualizaDetalhes();
        }

        private void AtualizaCell(int ridx, int cidx)
        {

        }

        private Estado getSelectedEstado()
        {
            return AutomatoInstanciado.Estados[(string)dataGridView1.Rows[lastRowIdx].Tag];
        }

        private void EditaEstado()
        {
            //   MessageBox.Show(RowIdx.ToString());

        }

        private void tsmEditarTransicao_Click(object sender, EventArgs e)
        {
            EditaTransicao();
        }

        private void tsmEditarEstado_Click(object sender, EventArgs e)
        {
            EditaEstado();

        }

        private void tsmSetEstadoInicial_Click(object sender, EventArgs e)
        {
            AutomatoInstanciado.setEstadoInicial(getSelectedEstado());
            RefreshRows();
        }

        private void RefreshRows()
        {
            foreach (DataGridViewRow h in dataGridView1.Rows)
            {
                h.HeaderCell.Value = AutomatoInstanciado.Estados[(string)h.Tag].ToString();
            }
            AtualizaDetalhes();
        }

        public void AtualizaAutomato()
        {


            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            foreach (Simbolo s in AutomatoInstanciado.Alfabeto.Values)
            {
                dataGridView1.Columns.Add(s.ToString(), s.ToString());
            }

            foreach (Estado e in AutomatoInstanciado.Estados.Values)
            {


                int pos = dataGridView1.Rows.Add();
                dataGridView1.Rows[pos].HeaderCell.Value = e.Nome;
                dataGridView1.Rows[pos].Tag = e.Nome;
                
                for (int cidx = 0; cidx < dataGridView1.Columns.Count; cidx++)
                {
                    String s = "";
                    if (e.Transicoes.ContainsKey(dataGridView1.Columns[cidx].Name))
                    {
                        Transicao t = e.Transicoes[dataGridView1.Columns[cidx].Name];
                        foreach (Estado ee in t.EstadosDestino)
                        {
                            s += ee.Nome + ", ";
                        }
                    }
                    if (s != "")
                    {
                        s = s.Substring(0, s.Length - 2);
                    }

                    dataGridView1.Rows[pos].Cells[cidx].Value = s;
                }
            }

            RefreshRows();
            AtualizaDetalhes();
            RefreshAlfabeto();
        }
        private void tsmSetFinal_Click(object sender, EventArgs e)
        {
            AutomatoInstanciado.setEstadoFinal(getSelectedEstado());
            RefreshRows();
        }

        private void AtualizaDetalhes()
        {
            lblDetalhes.Text = AutomatoInstanciado.Detalhes;
            lblDados.Text = AutomatoInstanciado.ErrosAutomato;
            //btnAFN_ANFDE.Enabled = AutomatoInstanciado.Tipo == TipoAT.AFND_E;
            

        }

        private void tsmExcluirTransicao_Click(object sender, EventArgs e)
        {
            if (lastColumnIdx < 0) {
                return;
            }
            Estado ee = getSelectedEstado();
            if (ee.Transicoes.ContainsKey(dataGridView1.Columns[lastColumnIdx].Name))
            {
                ee.Transicoes.Remove(dataGridView1.Columns[lastColumnIdx].Name);
            }
            AtualizaLastCell();
        }

        private void btnAFN_ANFDE_Click(object sender, EventArgs e)
        {
            try
            {
                TrasnformaAFND_AFD t = new TrasnformaAFND_AFD();

                t.AutomatoOriginal = AutomatoInstanciado;
                t.Tentativa3();

                AutomatoInstanciado = t.AutomatoNovo;

                AtualizaAutomato();
            }
            catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML Files|*.xml";
            sfd.ShowDialog();
            if (sfd.FileName != null && sfd.FileName != "")
            {
                Serializer s = new Serializer();
                SaveDataAutomato sd = new SaveDataAutomato();
                sd = sd.ConvertAutomato(AutomatoInstanciado);
                s.Grava(sd, sfd.FileName);
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = "XML Files|*.xml";
            sfd.ShowDialog();
            if (sfd.FileName != null && sfd.FileName != "")
            {
                Serializer s = new Serializer();
                SaveDataAutomato sd = (SaveDataAutomato) s.Busca(sfd.FileName, typeof(SaveDataAutomato ));
                AutomatoInstanciado = sd.ConvertSaveDataAutomato(sd);
                AtualizaAutomato();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutomatoInstanciado = new Automato();
            AtualizaAutomato();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gustavoAugustoHennigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GustavoHennig");
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void btnAFND_E_AFND_Click(object sender, EventArgs e)
        {
            TransformaAFNDE_AFND tr = new TransformaAFNDE_AFND();
            tr.automato = AutomatoInstanciado;
            tr.Converte();
            AtualizaAutomato();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("AVISO!\nAinda não está completamente implementado.");

            MinimizaAutomatoAFD ma = new MinimizaAutomatoAFD();
            ma.automato = AutomatoInstanciado;
            ma.Minimiza();
            AtualizaAutomato();

        }

        private void btnAnalisarSentenca_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ainda não foi implementado.");


            string testar = InputBox.Show("Analisar sentença", "Informe a sentença a ser analisada", "");


            if (AutomatoInstanciado.EstadoInicial.ConsomeSentenca(testar)) {
                MessageBox.Show("Sentença reconhecida.");
            } else {
                MessageBox.Show("Sentença não reconhecida.");
            }
            

        }
    }
}