


using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMan
{
    [Serializable]
    public class Simbolo
    {

        public Simbolo()
        {
            
        }

        public Simbolo(string simb) {
            simbolo = simb;
        }

        public string simbolo;


        public override string ToString()
        {
            return simbolo;
        }

        public override bool Equals(object obj)
        {

            try
            {
                if (obj == null)
                {
                    return false;
                }
                Simbolo s = (Simbolo)obj;

                try
                {
                    if (s.simbolo == simbolo)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    //throw;
                }

                try
                {
                    if (simbolo == (string)obj)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {

                    // throw;
                }
            }
            catch (Exception) {
                return false;
            }
            

            return false;
        }

        public bool isVazio { get { return simbolo == "E"; } }
    }
}
