


using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    [Serializable]
    public class Estado
    {
        public Estado()
        {
            Estado.Instanciados.Add(this);            
        }
        public Estado(string nome)
        {
            Nome = nome;
            Estado.Instanciados.Add(this);      
        }
        //public List<Transicao> Transicoes = new List<Transicao>();
        public Dictionary<string, Transicao> Transicoes = new Dictionary<string, Transicao>();
        public List<string> EstadosGerador_Pais = new List<string>();
        public List<string> EstadosUnificados = new List<string>();

        public string Nome;
        public int PosGrid;
        public bool isInicial;
        public bool isFinal;


        public static List<Estado> Instanciados = new List<Estado>();

        public Transicao getTransicao(Simbolo s, string nomeestadodest)
        {

            if (Transicoes.ContainsKey(s.simbolo + nomeestadodest))
            {
                return Transicoes[s.simbolo + nomeestadodest];
            }
            else
            {
                return null;
            }
            /*
            foreach (Transicao t in Transicoes)
            {
                if (t.Simbolo.Equals(dataGridView1.Columns[lastColumnIdx].Name))
                {
                    found = true;
                    AlteraTransicao.EditaTransicao(t, AutomatoInstanciado);
                    AtualizaCell(t);
                }
            }
            */
        }

        public void SyncTransicao(Transicao t)
        {

            if (Transicoes.ContainsKey(t.Simbolo.simbolo))
            {
                Transicao tt = Transicoes[t.Simbolo.simbolo]; //Transições existentes
                foreach (Estado e in t.EstadosDestino)
                { //Transições novas
                    if (!tt.EstadosDestino.Contains(e))
                    { //Se não existe, adiciona
                        tt.EstadosDestino.Add(e);
                    }
                }
            }
            else
            {
                Transicoes.Add(t.Simbolo.simbolo, t);
            }
        }

        public void setTransicao(Transicao t)
        {

            if (Transicoes.ContainsKey(t.Simbolo.simbolo))
            {
                Transicoes[t.Simbolo.simbolo] = t;

            }
            else
            {
                Transicoes.Add(t.Simbolo.simbolo, t);
            }
        }

        public bool EstadoDeterministico
        {
            get
            {

                foreach (Transicao t in Transicoes.Values)
                {
                    if (t.EstadosDestino.Count > 1)
                    {
                        return false;
                    }
                }

                return true;

            }

        }
        public override bool Equals(object obj)
        {

            try
            {
               // bool ret = false;

                if (obj == null)
                {
                    return false;
                }

                Estado c = (Estado)obj;



                return (c.Nome == Nome);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override string ToString()
        {

            return (isInicial ? ">" : "") + (isFinal ? "*" : "") + Nome;
        }

        public bool VaiParaFim()
        {
            return VaiParaFim(new List<Estado>());
        }

        public bool VaiParaFim(List<Estado> est_pesq)
        {

            if (!est_pesq.Contains(this))
            {
                est_pesq.Add(this);
            }

            if (this.isFinal)
            {
                return true;
            }
            else
            {
                foreach (Transicao t in Transicoes.Values)
                {
                    foreach (Estado ee in t.EstadosDestino)
                    {
                        if (!est_pesq.Contains(ee))
                        {
                            if (ee.VaiParaFim(est_pesq))
                            {
                                return true;
                            }
                            if (!est_pesq.Contains(ee))
                            {
                                est_pesq.Add(ee);
                            }
                        }
                        else
                        {

                        }
                    }
                }

                return false;
            }



        }

        public List<Estado> getTodosEstadosAlcancaveis() {
            return getTodosEstadosAlcancaveis(new List<Estado>());
        }

        public List<Estado> getTodosEstadosAlcancaveis(List<Estado> ePerc) {

//            List<Estado> ret = new List<Estado>();

            if (!ePerc.Contains(this))
            {
                ePerc.Add(this);

                foreach (Transicao t in Transicoes.Values)
                {
                    foreach (Estado ee in t.EstadosDestino)
                    {
                        if (!ePerc.Contains(ee))
                        {
                            ee.getTodosEstadosAlcancaveis(ePerc);
                        }
                    }
                }

            }
            
            {
 
            }

            return ePerc;


        }

        public List<Estado> getEstadosDestinos(Simbolo s)
        {
            if (Transicoes.ContainsKey(s.simbolo))
            {
                return Transicoes[s.simbolo].EstadosDestino;
            }
            else
            {
                return new List<Estado>();
            }
        }

        public List<Estado> getEstadosDestinosRebuilded(Simbolo s)
        {
            if (Transicoes.ContainsKey(s.simbolo))
            {
                return new List<Estado>( Transicoes[s.simbolo].EstadosDestino);
            }
            else
            {
                return new List<Estado>();
            }
        }


        public void SyncEstado(Estado ee)
        {
            if (ee.Nome != this.Nome) {
                throw new Exception("Não é possível sincronizar estados diferentes.");
            }

            foreach (Transicao t in ee.Transicoes.Values ) {
                if (!this.Transicoes.ContainsKey(t.Simbolo.simbolo)) {
                    this.Transicoes.Add(t.Simbolo.simbolo, t);
                }
            }

            if (!this.EstadoDeterministico) {
                throw new Exception("Esse estado acabou de deixar de ser deterministico.");
            }

        }

        public List<Estado> getEstadosVazios()
        {
            return getEstadosVazios(new List<Estado>());
        }

        public List<Estado> getEstadosVazios(List<Estado> ePercorridos)
        {

            List<Estado> ret = new List<Estado>();

            if (ePercorridos.Count == 0 && !ePercorridos.Contains(this))
            {
                ret.Add(this);
            }

            if (!ePercorridos.Contains(this) && Transicoes.ContainsKey("E"))
            {


                ePercorridos.Add(this); 
                foreach (Estado e in Transicoes["E"].EstadosDestino) {
                    if (!ret.Contains(e)) {
                        ret.Add(e);
                    }
                    foreach (Estado ee in e.getEstadosVazios(ePercorridos))
                    {
                        if (!ret.Contains(ee))
                        {
                            ret.Add(ee);
                        }
                    }
                }
            }
            else
            {
                //Não possui transições vazias
            }

            return ret;
        }

        public void EliminarE(Dictionary<string, Simbolo> Alfabeto)
        {

            //Testa-se o estado atual com cada simbolo do alfabeto
            foreach (Simbolo s in Alfabeto.Values)
            {
                //Encontra todos alcançáveis com movimentos vazios
                foreach (Estado e in getEstadosVazios())
                {
                
                    if (!s.isVazio)
                    {

                        //Encontra todos estados alcançáveis com esse símbolo
                        foreach (Estado ee in e.getEstadosDestinosRebuilded(s))
                        {
                            //Para cado estado alcaçado verifica-se os vazios e 
                            // adiciona na lista como destino do estado this.
                            foreach (Estado eee in ee.getEstadosVazios())
                            {
                                
                                //Adiciona novas transições ou novos estados destino
                                if (!this.Transicoes.ContainsKey(s.simbolo))
                                {
                                    Transicao t = new Transicao(this);
                                    t.Simbolo = s;
                                    t.AddEstadoDest(eee);
                                    this.Transicoes.Add(s.simbolo, t);
                                }
                                else {
                                    this.Transicoes[s.simbolo].AddEstadoDest(eee);
                                }
                            } 
                        }
                    }

                    //Se era possível chegar a algun estado final passando por E, 
                    // então esse estado deve ser final também.
                    if (e.isFinal) {
                        this.isFinal = true;
                    }
                }
            }
        }


        public bool ConsomeSentenca(string testar)
        {
            testar = testar.ToUpper();
            if(testar.Length > 0){
                string ch = testar.Substring(0,1);
                if(Transicoes.ContainsKey(ch)){
                    
                    bool encontrou = false;
                    foreach(Estado e in Transicoes[ch].EstadosDestino){
                        
                        if(testar.Length == 1 && e.isFinal){
                            return true;
                        }else{
                            string novo = testar.Substring(1,testar.Length-1);
                            if(e.ConsomeSentenca(novo)){
                                encontrou = true;
                                break;
                            }
                        }
                    }

                    return encontrou;
                }else{
                    return false;
                }
                
            
            }
            return false;

        }
    }
}
