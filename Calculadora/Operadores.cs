using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operadores
    {
        private int n1;
        private int n2;

        public Operadores(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

        public int Suma()
        {
            var resultado = n1 + n2;
            return resultado;
        }
        public int Resta()
        {
            var resultado = n1 - n2;
            return resultado;
        }
        public int Multiplicacion()
        {
            var resultado = n1 * n2;
            return resultado;
        }

        public int GetDivicion()
        {
            var resultado = n1 / n2;
            return resultado;
        }
    }
}
