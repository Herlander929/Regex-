


using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    [Serializable]
    public class Transicao
    {

        public Transicao() { 
        
        }
        public Transicao(Estado origem) {
            EstadoOrigem = origem;
        }
        public Estado EstadoOrigem;

        //public List<Simbolo> Simbolos = new List<Simbolo>();
        public Simbolo Simbolo;

        public List<Estado> EstadosDestino = new List<Estado>();

        public void AddEstadoDest(Estado est) {
            //foreach (Estado e in EstadosDestino)
           // {
                if (!EstadosDestino.Contains(est))
                {
                    EstadosDestino.Add(est);
                }
           // }
        }

        public override bool Equals(object obj)
        {

           // bool ret = false;

            if (obj == null) {
                return false;
            }

            Transicao c = (Transicao)obj;

            //TODO: Correct this
            if (!c.EstadosDestino.Equals(this.EstadosDestino)) {

                return false;
            }
            
            if (!c.EstadoOrigem.Equals(this.EstadoOrigem))
            {
                return false;
            }
            /*
            bool found = false;

            foreach (Simbolo s in this.Simbolos) {
                found = false;
                foreach (Simbolo ss in c.Simbolos)
                {
                    if (s.Equals(ss)) {
                        found = true;
                    }
                }
                if (!found) {
                    return false;
                }
            }
            */
            if (Simbolo.Equals(c.Simbolo)) {
                return true;
            }
            return false;
            


        }

        public Estado getNewEstadoFromDestinos() {

            string nome_novo_estado = "";
            Dictionary<string, Transicao> transicoes = new Dictionary<string, Transicao>();
            bool EhFinal = false;
            bool Ehnicial = false;

            foreach (Estado e in EstadosDestino) {
                nome_novo_estado += nome_novo_estado + e.Nome + "_";
                if(e.isFinal){
                    EhFinal =true;
                }
                if(e.isInicial){
                    Ehnicial = true;
                }
                foreach(Transicao t in e.Transicoes.Values){
                    if(!transicoes.ContainsKey(t.Simbolo.simbolo)){
                        transicoes.Add(t.Simbolo.simbolo,t);
                    }
                }
            }

            if (nome_novo_estado != "") {
                nome_novo_estado = nome_novo_estado.Substring(0, nome_novo_estado.Length - 1);
            }

            Estado novoEstado = new Estado(nome_novo_estado);
            novoEstado.Transicoes = transicoes;
            novoEstado.isFinal = EhFinal;
            novoEstado.isInicial = Ehnicial;

            return novoEstado;
            
        }

        
    }
}
