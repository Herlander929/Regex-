


using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    [Serializable]
    public class SaveDataAutomato
    {
        public List<string> Estados = new List<string>();
        public List<string> Alfabeto = new List<string>();
        public List<SaveDataTransicao> Transicoes = new List<SaveDataTransicao>();
        public string EstadoInicial;
        public List<string> EstadosFinais = new List<string>();

        public SaveDataAutomato ConvertAutomato(Automato aut)
        {

            SaveDataAutomato sa = new SaveDataAutomato();

            foreach (Estado e in aut.Estados.Values)
            {
                sa.Estados.Add(e.Nome);
                if (e.isFinal)
                {
                    sa.EstadosFinais.Add(e.Nome);
                }
                foreach (Transicao t in e.Transicoes.Values)
                {
                    SaveDataTransicao st = new SaveDataTransicao();
                    st.EstadoOrigem = e.Nome;
                    foreach (Estado ee in t.EstadosDestino)
                    {
                        st.EstadosDestino.Add(ee.Nome);
                    }
                    st.Simbolo = t.Simbolo.simbolo;
                    sa.Transicoes.Add(st);
                }
            }

            if (aut.EstadoInicial != null)
            {
                sa.EstadoInicial = aut.EstadoInicial.Nome;
            }

            foreach (Simbolo s in aut.Alfabeto.Values)
            {
                sa.Alfabeto.Add(s.simbolo);
            }

            return sa;
        }

        public Automato ConvertSaveDataAutomato(SaveDataAutomato sa)
        {

            Automato aut = new Automato();

            foreach (string s in sa.Alfabeto)
            {
                Simbolo si = new Simbolo(s);
                aut.Alfabeto.Add(s, si);
            }

            foreach (string estado in sa.Estados)
            {
                Estado e = new Estado(estado);
                e.isFinal = sa.EstadosFinais.Contains(estado);
                e.isInicial = sa.EstadoInicial == estado;
                aut.Estados.Add(estado, e);

            }

            foreach (Estado e in aut.Estados.Values){
                foreach (SaveDataTransicao t in sa.Transicoes)
                {
                    if (t.EstadoOrigem == e.Nome)
                    {
                        Transicao tr = new Transicao(e);
                        tr.Simbolo = aut.Alfabeto[t.Simbolo];
                        foreach(string d in t.EstadosDestino){
                            tr.EstadosDestino.Add(aut.Estados[d]);
                        }
                        e.Transicoes.Add(tr.Simbolo.simbolo, tr);
                    }
                }
            }

            if (sa.EstadoInicial != null && sa.EstadoInicial!= "") {
                aut.EstadoInicial = aut.Estados[sa.EstadoInicial];
            }
            return aut;
        }
    }



    public class SaveDataTransicao
    {

        public string EstadoOrigem;
        public string Simbolo;
        public List<string> EstadosDestino = new List<string>();
    }
}
