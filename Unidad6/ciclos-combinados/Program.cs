using System;

namespace ciclos_combinados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ciclos combinados: 
            //For con For
            int e, n, prom, acu, cont;
            /* for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 210; x++)
                {
                    acu = 0;
                    Console.WriteLine("Ingrese la edad:");
                    n = int.Parse(Console.ReadLine());
                    acu += n;             
                }
                prom = actu / 20;
                Console.WriteLine("El promedio es:" + prom);
            } */

            //for con while:
            /* for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la edad:");
                n = int.Parse(Console.ReadLine());
                acu = 0;
                cont = 0;
                
                while (n != 0)
                {
                    acu += n;
                    cont ++;
                    Console.WriteLine("Ingrese la edad:");
                    n = int.Parse(Console.ReadLine());
                }
                prom = actu / cont;
                Console.WriteLine("El promedio es:" + prom);
            } */

            
                //While con for:
                /* Console.WriteLine("Ingrese 1 para comenzar a procesar o 0 para teriminar");
                n = int.Parse(Console.ReadLine())
                while (n != 0)
                {
                    acu = 0;
                    for (int x = 0; x < 20; x++)
                    {
                        Console.WriteLine("Ingrese la edad:");
                        n = int.Parse(Console.ReadLine());
                        acu += n;             
                    }
                    prom = actu / 20;
                    Console.WriteLine("El promedio es:" + prom);
                    Console.WriteLine("Ingrese 1 para continuar o 0 para teriminar");
                    n = int.Parse(Console.ReadLine())   
                } */
                
                //While con while:
                Console.WriteLine("Ingrese la edad:");
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    acu = 0;
                    cont = 0;
                    while (n != 0)
                    {
                        acu += n;
                        cont ++;
                        Console.WriteLine("Ingrese la edad:");
                        n = int.Parse(Console.ReadLine());
                    }
                    prom = actu / cont;
                    Console.WriteLine("El promedio es:" + prom);
                    Console.WriteLine("Ingrese la edad para continuar o negativo para cotar:");
                    n = int.Parse(Console.ReadLine());
                }

        }
    }
}
