


using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    public class TransformaAFNDE_AFND
    {
        public Automato automato;

        private List<Estado> estadosPercorridos = new List<Estado>();
        /*
        public void EClose(Estado e, string simbolo)
        {

            if (!estados.Contains(e))
            {
                estados.Add(e);

              //  if (e.Transicoes.ContainsKey[simbolo])
                {

                    foreach (Estado ee in e.Transicoes[simbolo].EstadosDestino)
                    {
               //         EClose(ee);
                    }
                }
            }

        }
        */
        /*
             * Encontrar todos estados que se consegue chegar passando por E
             * Comparar cada estado encontrado com o simbolo
             * Fazer a união do resultado
             * Criar uma transição no estado em questão, com todos destinos apontando para os estados resultantes da operação.
             * 
             * 
             
             */
        /*
        public void Tent1()
        {
            //Para cada estado existente, econtrar todos estado que podem ser acessados por movimentos vazios.

            foreach (Estado e in automato.Estados.Values)
            {
                
                e.EliminarE( );

                        tmp_Estados = new List<Estado>();
                        EClose(e,"E");
                        // em tmp_estados estão o EClose(Estado, E);
                        foreach (Estado ee in tmp_Estados)
                        {
                            EClose(ee, s.simbolo);
                        }
                    }
                

            }
        */
        public void Converte() {

            foreach (Estado e in automato.Estados.Values)
            {
                e.EliminarE(automato.Alfabeto);
            }
            foreach (Estado e in automato.Estados.Values)
            {
                if(e.Transicoes.ContainsKey("E")){
                    e.Transicoes.Remove("E");
                }
            }

            if (automato.Alfabeto.ContainsKey("E")) {
                automato.Alfabeto.Remove("E");
            }

        
        }
    }
}
