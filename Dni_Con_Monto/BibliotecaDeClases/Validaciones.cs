using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Validaciones
    {
        public bool ValidarQueSeaDni(string numeroString, out int dni)
        {
            bool retorno = false;
            bool flag = false;
            flag = int.TryParse(numeroString, out int num);
            if(flag == true)
            {
                if(numeroString.Length == 7 || numeroString.Length == 8)
                {
                    retorno = true;
                    dni = num;
                }
                else
                {
                    dni = 0;
                }
            }
            else
            {
                dni = 0;
            }

            return retorno;
        }

        public bool ValidarQueSeaMonto(string numeroString, out int monto)
        {
            bool retorno = false;
            bool flag = false;
            flag = int.TryParse(numeroString, out int num);
            if (flag == true && (num > 0 && num <= 5000))
            {
                retorno = true;
                monto = num;
            }
            else
            {
                retorno = false;
                monto = 0;
            }

            return retorno;
        }
    }
}
