using System;

namespace ejemplos_if
{
    class Program
    {
        static void Main(string[] args)
        {
            //BLOQUE IF: CONDICIONALES.
            //
            //

            int edad = 20;

            if(edad > 21){
                Console.WriteLine("Es mayor");
            }else if(edad < 12){
                    Console.WriteLine("Es un niño");
            }else {
                Console.WriteLine("Es menor");
            }
        }
    }
}
