
/*
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    [Serializable]
    public class Automato
    {
        //public List<Estado> Estados = new List<Estado>();
        public Dictionary<string, Estado> Estados = new Dictionary<string, Estado>();
        public Estado EstadoInicial;
        public Dictionary<string, Simbolo> Alfabeto = new Dictionary<string, Simbolo>();

        private bool ExisteExtado(string nome)
        {

            return Estados.ContainsKey(nome);

            /*
              foreach (Estado e in Estados) {
                  if (e.Nome == nome) {
                      return true;
                      // break;
                  }
              }
              */
        }
        private bool ExisteSimbolo(string simbolo)
        {
            return Alfabeto.ContainsKey(simbolo);
        }
        public Estado AdicionaEstado(string nome)
        {
            nome = nome.ToUpper();

            if (ExisteExtado(nome))
            {
                throw new Exception("Esse estado já existe!");
            }

            Estado e = new Estado(nome);
            Estados.Add(nome, e);
            return e;

        }

        public void AdicionaTransicao(string estadoOr, string estadoDest, string simbolo)
        {
        }

        public void AdicionaSimbolo(string simbolo)
        {

            simbolo = simbolo.ToUpper();
            if (Alfabeto.ContainsKey(simbolo))
            {
                throw new Exception("Símbolo já existe.");
            }

            Alfabeto.Add(simbolo, new Simbolo(simbolo));
        }

        public void RemoveSimbolo(string simbolo)
        {

            simbolo = simbolo.ToUpper();

            if (!Alfabeto.ContainsKey(simbolo))
            {
                throw new Exception("Símbolo não encontrado.");
            }

            Alfabeto.Remove(simbolo);
        }

        public string getAlfabeto()
        {

            string ret = "";
            foreach (Simbolo s in Alfabeto.Values)
            {
                ret += s + ", ";
            }

            if (ret.Length > 2)
            {
                ret = ret.Substring(0, ret.Length - 2);
            }

            return ret;
        }

        public string ErrosAutomato
        {

            get
            {
                string msg = "";

                try
                {
                    

                    if (Alfabeto.Count == 0)
                    {
                        msg += "Nenhum símbolo no alfabeto.\n";
                    }
                    if (Estados.Count == 0)
                    {
                        msg += "Nenhum estado inserido.\n";
                    }
                    if (EstadoInicial == null)
                    {
                        msg += "Estado incial não definido.\n";
                    }
                    if (!PossuiEstadoFinal)
                    {
                        msg += "Não foi definido um estado final.\n";
                    }
                    if (!InicioChegaAoFim())
                    {
                        msg += "Não existe ligação entre o estado inicial e algum estado final.\n";
                    }
                }
                catch (Exception e) {
                    msg += e.Message+"\n";
                }
                return msg;
            }
        }

        public bool ValidaAutomato()
        {


            if (ErrosAutomato != "")
            {
                throw new Exception(ErrosAutomato);
            }

            return true;

        }

        public bool PossuiEstadoFinal
        {
            get
            {
                foreach (Estado e in Estados.Values)
                {
                    if (e.isFinal)
                    {
                        return true;
                    }
                }
                return false;
            }

        }

        public void RemoveEstado(string s)
        {
            s = s.ToUpper();

            if (!Estados.ContainsKey(s))
            {
                throw new Exception("Estado não encontrado.");
            }

            Estados.Remove(s);
        }

        public TipoAT Tipo
        {
            get
            {

                bool Deterministico = true;
                int cntNaoDet = 0;
                bool UtilizaVazio = false;
                foreach (Estado e in Estados.Values)
                {

                    if (!e.EstadoDeterministico)
                    {
                        cntNaoDet++;
                        Deterministico = false;
                    }

                    if (e.Transicoes.ContainsKey("E"))
                    {
                        UtilizaVazio = true;
                    }

                }
                if (UtilizaVazio)
                {
                    return TipoAT.AFND_E;
                }
                if (Deterministico)
                {
                    return TipoAT.AFD;
                }
                else
                {
                    return TipoAT.AFND;
                }
            }
        }

        public string Detalhes
        {
            get
            {

                string ret = "";

                ret += "TIPO: ";

                switch (Tipo)
                {
                    case TipoAT.AFD:
                        ret += "AFD";
                        break;
                    case TipoAT.AFND:
                        ret += "AFND";
                        break;
                    case TipoAT.AFND_E:
                        ret += "AFND-ε";
                        break;
                }
                ret += "\n";

                return ret;
            }


        }

        public void setEstadoInicial(Estado e)
        {
            if (EstadoInicial != null)
            {
                EstadoInicial.isInicial = false;
            }
            EstadoInicial = e;
            EstadoInicial.isInicial = true;

        }

        public void setEstadoFinal(Estado e)
        {

            e.isFinal = !e.isFinal;
        }

        public bool InicioChegaAoFim() {

            if (EstadoInicial == null) {
                throw new Exception("Estado inicial não definido.");
            }

            return EstadoInicial.VaiParaFim(); ;
        }

        public List<Estado> getEstadosDestinos(List<string> EstadosOrigem, Simbolo s) {
            List<Estado> ret = new List<Estado>();
      
            foreach ( string estado in EstadosOrigem){
                
                foreach(Estado e in Estados[estado].getEstadosDestinos(s)){
                    if (!ret.Contains(e))
                    {
                        ret.Add(e);
                    }
                }
            }
            return ret;

        }
    }

    public enum TipoAT
    {
        AFD = 0, AFND = 1, AFND_E = 2
    }
}
