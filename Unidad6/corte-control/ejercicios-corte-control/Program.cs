using System;

namespace ejercicios_corte_control
{
    class Program
    {
        static void Main(string[] args)
        {
            /* VARIBALES: */
            int aventuraActual, numeroPaquete, cantidadPersonas, horasAct, tipoAventura, bVenta, bhoras, menorHoras, menorPaquete, contPaq, acuPersonas;
            float precioXPersona, recaudo, mayorVenta;

            Console.WriteLine("Número de paquete:");
            numeroPaquete = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de personas incluidas:");
            cantidadPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine("Precio por persona:");
            precioXPersona = float.Parse(Console.ReadLine());
            Console.WriteLine("Horas: ");
            horasAct = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de aventura:");
            tipoAventura = int.Parse(Console.ReadLine());

            recaudo = 0;
            acuPersonas = 0;
            bhoras = 0;
            mayorVenta = 0;
            menorHoras = 0;
            menorPaquete = 0;

            while (numeroPaquete != 0)
            {
                aventuraActual = tipoAventura;
                contPaq = 0;
                bVenta = 0;

                while(tipoAventura == aventuraActual)
                {
                    contPaq++;
                    acuPersonas += cantidadPersonas;
                    recaudo = precioXPersona * cantidadPersonas;
                    if (bVenta == 0)
                    {
                        bVenta = 1;
                        mayorVenta = recaudo;
                    }else if (recaudo > mayorVenta){
                        mayorVenta = recaudo;
                    }
                    if (bhoras == 0)
                    {
                        bhoras = 1;
                        menorHoras = horasAct;
                        menorPaquete = numeroPaquete;
                    }else if(horasAct < menorHoras) {
                        menorHoras += horasAct;
                        menorPaquete = numeroPaquete;
                    }

                /* Punto C */
                Console.WriteLine("Recaudo: $" + recaudo);

                Console.WriteLine("Número de paquete:");
                numeroPaquete = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad de personas incluidas:");
                cantidadPersonas = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio por persona:");
                precioXPersona = float.Parse(Console.ReadLine());
                Console.WriteLine("Horas: ");
                horasAct = int.Parse(Console.ReadLine());
                Console.WriteLine("Tipo de aventura:");
                tipoAventura = int.Parse(Console.ReadLine());

                }

                /* Punto A */
                Console.WriteLine("Los paquetes vendidos en la aventura " + aventuraActual + " son: " + contPaq);
                /* Punto D */
                Console.WriteLine("Venta de mayor importe: $" + mayorVenta);

            }
            /* Punto B */
            Console.WriteLine("La cantidad total de personas concurridas es: " + acuPersonas);
            /* Punto E */
            Console.WriteLine(menorPaquete + " fue el paquete con menos horas. Con un total de: " + menorHoras + " horas."); 




        }
    }
}
