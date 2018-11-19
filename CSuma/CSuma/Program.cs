using System;

namespace CSuma
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Vamos a sumar dos números.");

            //Console.Write("Dime el primero: ");
            //string stringNum1 = Console.ReadLine();
            //decimal num1 = decimal.Parse(stringNum1);

            //Console.Write("Dime el segundo: ");
            //string stringNum2 = Console.ReadLine();
            //decimal num2 = decimal.Parse(stringNum2);

            //decimal suma = num1 + num2;
            //Console.WriteLine("La suma de ambos es " + suma + ".");

            decimal primerNumero = readDecimal("Primer número: ");
            decimal segundoNumero = readDecimal("Segundo número: ");
            decimal suma = primerNumero + segundoNumero;
            Console.WriteLine("La suma es: " + suma);

        }

        private static decimal readDecimal(string label) {
            Console.Write(label);
            string stringDecimal = Console.ReadLine();
            return decimal.Parse(stringDecimal);
        }

    }
}
