


using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    public class MinimizaAutomatoAFD
    {


        public Automato automato;
        public void EncontraEstadosMortos() {


            List<Estado> mortos  = new List<Estado>();

            foreach (Estado e in automato.Estados.Values) {
                if (!e.VaiParaFim()) {
                    mortos.Add(e);
                }
            }

            foreach (Estado e in mortos) {
                automato.Estados.Remove(e.Nome);
            }

            
        }

        public void EncontraEstadosInacessiveis() {

            List<Estado> acessiveis = automato.EstadoInicial.getTodosEstadosAlcancaveis();
            List<Estado> inacessiveis = new List<Estado>();
            
                

            foreach (Estado e in automato.Estados.Values)
            {
                if (!acessiveis.Contains(e))
                {
                    inacessiveis.Add(e);
                }
            }

            foreach (Estado e in inacessiveis) {
                automato.Estados.Remove(e.Nome);
            }

        }

        public void ExluiTransacoesParaEstadoInexistente() { 
            //TODO:

            List<Estado> remover;
            foreach (Estado e in automato.Estados.Values) {
                foreach (Transicao t in e.Transicoes.Values) {
                    remover = new List<Estado>();
                    foreach (Estado  ed in t.EstadosDestino) {
                        if (!automato.Estados.ContainsKey(ed.Nome)) {
                            remover.Add(ed);
                        }
                    }
                    foreach (Estado er in remover) {
                        t.EstadosDestino.Remove(er);
                    }

                }

            }
        }

        public void Minimiza() {
            EncontraEstadosMortos();
            EncontraEstadosInacessiveis();
            ExluiTransacoesParaEstadoInexistente();
        }
        
    }
}
