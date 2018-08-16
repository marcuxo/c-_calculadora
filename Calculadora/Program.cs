using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo !!! \nDesde .Net\n");
            Boolean cal = true;
            while (cal)
            {
                Console.WriteLine("Bienvenido a la Calculadora, para salir escriba E mayuscula");
                Console.WriteLine("Ingresa el primer numero: ");
                int uno = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la operacion a realizar(+,-,*,/): ");
                var ope = Console.ReadLine();
                Console.WriteLine("Ingresa el segundo numero: ");
                int dos = int.Parse(Console.ReadLine());

                Operadores oper1 = new Operadores(uno, dos);

                switch (ope)
                {
                    case "+":
                        Console.WriteLine("El resultado de la suma de los numeros es: " + oper1.Suma());
                        break;
                    case "-":
                        Console.WriteLine("El resultado de la suma de los numeros es: " + oper1.Suma());
                        break;
                    case "*":
                        Console.WriteLine("El resultado de la suma de los numeros es: " + oper1.Multiplicacion());
                        break;
                    case "/":
                        Console.WriteLine("El resultado de la suma de los numeros es: " + oper1.GetDivicion());
                        break;
                    case "E":
                        cal = false;
                        break;
                    default:
                        Console.WriteLine("Operador no valido.");
                        break;
                }
            }
        }
    }
}
