using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Matematicas
    {
        //2^3 = eit
        public static int Potencia(int numeroBase, int exponente)
        {
            int resultado = 1; //numeroBase;
           for(int i=0; i < exponente; i++)
            {
                resultado = resultado * numeroBase;
            }
            return resultado;
        }
    }
}
