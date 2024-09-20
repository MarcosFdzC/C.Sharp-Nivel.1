using System;

namespace ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            /* SINTAXIS DE LOS CICLOS */

            /* FOR: */
            for (int x = 0; x < 10; x++) {
                Console.WriteLine("Hello World!");
            }

            /* WHILE: */
            int n;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            while (n != 0) {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }

            /* DO WHILE */
            do {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }while (n != 0)


        }
    }
}
