

using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    [Obsolete]
    public class EstadoAgrupado
    {

        public List<Estado> Estados = new List<Estado>();

        public void AdicionaSeNovo(Estado e){
            if(!Estados.Contains(e)){
                Estados.Add(e);
            }
        }

        public string getString() {
            string ret = "";
            foreach (Estado e in Estados) { 
                ret +=  e.Nome + "_";
            }

            if(ret!=""){
                ret = ret.Substring(0,ret.Length-1);
            }

            return ret;
        }

        public Estado getEstadoResultante() {
            return new Estado(getString());
        }

    }
}
