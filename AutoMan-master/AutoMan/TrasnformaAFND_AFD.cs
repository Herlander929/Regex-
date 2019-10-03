

using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    public class TrasnformaAFND_AFD
    {

        public Automato AutomatoOriginal;
        public Automato AutomatoNovo;

        //private List<Estado> EstadosPesquisados = new List<Estado>();
       // private List<Estado> NovosEstados = new List<Estado>();
        private Dictionary<string, Estado> EstadosNovos = new Dictionary<string, Estado>();

        /*
         Como funciona:
         *  Precisa ter todas transições
         * O Nome do estado = nome de todas estados unidos
         * 
         * Inicial com a -> Novo estado
         * Inicial com b -> Novo estado
         
         */




        [Obsolete]
        public Automato Convert(Automato original)
        {


            if (original == null || original.EstadoInicial == null)
            {
                throw new Exception("Estado inicial não definido.");
            }

            AutomatoOriginal = original;

            Estado ini = original.EstadoInicial;

            AutomatoNovo = new Automato();
            //A única coisa que vem do automato anterior é o estado inicial.
            //O resto deve ser criado na medida do necessário


           // ini.EstadosOrigem.Add(ini.Nome);
            return null;

        
        }

        [Obsolete]
        public void CriaNovoEstado(Transicao progenitor)
        {
            string nome_novo_estado = "";
            Dictionary<string, Transicao> transicoes = new Dictionary<string, Transicao>();
            bool EhFinal = false;

            foreach (Estado e in progenitor.EstadosDestino)
            {
                nome_novo_estado += nome_novo_estado + e.Nome + "_";
                if (e.isFinal)
                {
                    EhFinal = true;
                }
                foreach (Transicao t in e.Transicoes.Values)
                {
                    if (!transicoes.ContainsKey(t.Simbolo.simbolo))
                    {
                        transicoes.Add(t.Simbolo.simbolo, t);
                    }
                }
            }

            if (nome_novo_estado != "")
            {
                nome_novo_estado = nome_novo_estado.Substring(0, nome_novo_estado.Length - 1);
                //  transicoes.
            }
            //Verificar se esse estado já não foi criado, caso tenha sido, 
            // as transições deve apontar para lah.


            Estado novoEstado = new Estado(nome_novo_estado);
            novoEstado.Transicoes = transicoes;
            novoEstado.isFinal = EhFinal;
            novoEstado.isInicial = false;

            progenitor.EstadosDestino.Clear();
            progenitor.EstadosDestino.Add(novoEstado);

        }

        [Obsolete]
        private void PesquisaEstado(Estado e)
        {

            foreach (Transicao t in e.Transicoes.Values)
            {
                //Para cada transição (Estado/Simbolo)  verificar se existe mais 
                // de um estado destino para o mesmo simbolo.

                Dictionary<string, Transicao> TransicoesBoas = new Dictionary<string, Transicao>();


                // AutomatoOriginal.getEstadosDestinos(

                //  t.Simbolo.simbolo
                if (t.EstadosDestino.Count > 1)
                {

                    //Caso exista, deve se verificar se esse estado já existe.
                    //Caso existe a transições do estado atual devem apontar para o estado existente
                    //Caso não exista, um novo estado deve ser criado.
                    CriaNovoEstado(t);

                }
                else
                {
                    TransicoesBoas.Add(t.Simbolo.simbolo, t);

                    //NovosEstados.Add(
                    //O estado atual está deterministico
                }


                //Contrala quais estados já foram pesquisados
                //Esses ainda são estados do automato 
            //    EstadosPesquisados.Add(e);

                foreach (Estado ei in t.EstadosDestino)
                {
                    PesquisaEstado(ei);
                }


            }
        }

        public void Teste(Estado ei)
        {

            List<Estado> ests = new List<Estado>();

            foreach (Transicao t in ei.Transicoes.Values)
            {
                Estado e = t.getNewEstadoFromDestinos();

                if (!ests.Contains(e))
                {
                    //Monta a lista de novos estados.
                    ests.Add(e);
                    Teste(ei);//Varre o novo estado criado.
                }
            }



        }

        public Estado getNewEstado(string nome)
        {
            return new Estado(nome);
        }

        public void Tentativa3()
        {

            AutomatoNovo = new Automato();

            AutomatoNovo.Alfabeto = AutomatoOriginal.Alfabeto;

            if (AutomatoOriginal.EstadoInicial == null) {
                throw new Exception("Estado inicial não definido.");
            }

            Estado novoini = new Estado(AutomatoOriginal.EstadoInicial.Nome);
            novoini.isInicial = true;
            novoini.EstadosUnificados.Add(novoini.Nome);
            EstadosNovos.Add(novoini.Nome, novoini);
            AutomatoNovo.EstadoInicial = novoini;
            ProxEst1(novoini);

            AutomatoNovo.Estados = EstadosNovos;


        }
        public void ProxEst1(Estado e_origem) {
            
            List<Estado> ests = new List<Estado>();

            foreach (Simbolo s in AutomatoOriginal.Alfabeto.Values)
            {
                //Retorna a lista de estados destinos
                Estado enew = ProxEst(e_origem, s, AutomatoOriginal);
                if (enew != null)
                {
                    ests.Add(enew);
                }
            }
            //A primeira rodada de novo estados foi concluida
            foreach (Estado ee in ests)
            {
                if (EstadosNovos.ContainsKey(ee.Nome))
                {
                    //Sincroniza as transições
                    EstadosNovos[ee.Nome].SyncEstado(ee);
                }
                else
                {

                    if (!isInEstadosNovos(ee))
                    {
                        EstadosNovos.Add(ee.Nome, ee);
                        ProxEst1(ee);
                    }
                    else {
                        EstadosNovos.Add(ee.Nome, ee);
                    }
                }
            }
        }


        public bool isInEstadosNovos(Estado e) {

            bool encontrou1 =false ;
            foreach (Estado ee in EstadosNovos.Values) {
                foreach (string s in e.EstadosUnificados) {
                    encontrou1 =false;
                    foreach (string ss in ee.EstadosUnificados) {
                        if (ss == s) {
                            encontrou1 = true;
                        } 
                    }
                    if (!encontrou1)
                    {
                        encontrou1 = false;
                        break;
                    }
                }
                if (encontrou1) {
                    return true;
                }
            }
            return false;
        }

        public Estado ProxEst(Estado e, Simbolo s, Automato aut)
        {


            //Procura todos destinos para a consulta atual
            List<Estado> dest = aut.getEstadosDestinos(e.EstadosUnificados, s);


            bool EhFinal = false;
            foreach (Estado eee in dest) {
                if (eee.isFinal) {
                    EhFinal = true;
                    break;
                }
            }


            if (dest.Count == 0) { return null; }

            //Gera o nome do novo estado
            string nomestados = getStringEstado(dest);

            Estado estadonovo;
            //Verifica se o novo estado já foi criado

            //Se ainda não foi, o novo estado é criado
            if (EstadosNovos.ContainsKey(nomestados))
            {
                estadonovo = EstadosNovos[nomestados];
            }
            else
            {
                estadonovo = new Estado(nomestados);
            }

            estadonovo.isFinal |= EhFinal;

            //Os estados unificados do pai são guardados no novo estado gerado.
            estadonovo.EstadosGerador_Pais = e.EstadosUnificados;
            
            //Os estados que foram referenciados para montar este são guardados.
            estadonovo.EstadosUnificados = getEstadosOrigem(dest);

            //As as transições do estado criador são apagadas.
            //    e.Transicoes.Clear();


            //Um única nova transição é criada
            Transicao nova = new Transicao(e);
            nova.EstadosDestino.Add(estadonovo);//O estado novo será destruido mais adiantes, corrigir as referências
            nova.Simbolo = s;

            //A transição é adicionada para o simbolo que está sendo pesquisado.
            e.Transicoes.Add(s.simbolo, nova);

            return estadonovo;


        }
        [Obsolete]
        public EstadoAgrupado BuscaProxEstados(EstadoAgrupado e, Simbolo s, Automato aut)
        {

            EstadoAgrupado ret = new EstadoAgrupado();

            foreach (Estado est in e.Estados)
            {
                /*
                aut.getEstadosDestinos(
                if (est.Transicoes.ContainsKey(s.simbolo)) { 
                    foreach(Es est.Transicoes[s.simbolo].EstadosDestino
                    ret.AdicionaSeNovo(
                }
*/

            }
            return null;
        }
        public List<string> getEstadosOrigem(List<Estado> estados)
        {
            List<string> ret = new List<string>();

            foreach (Estado e in estados)
            {
                ret.Add(e.Nome);
            }

            return ret;

        }
        public string getStringEstado(List<Estado> estados)
        {
            string ret = "";
            foreach (Estado e in estados)
            {
                ret += e.Nome + "_";
            }

            if (ret != "")
            {
                ret = ret.Substring(0, ret.Length - 1);
            }

            return ret;
        }
    }
}
