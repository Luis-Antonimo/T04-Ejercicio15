using System;

namespace T04Ejercicio15
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba un número:");
            double numero = Convert.ToDouble(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número SÍ es divisible entre 2.");
            }
            else
            {
                Console.WriteLine("El número NO es divisible entre 2");
            }
        }
    }
}