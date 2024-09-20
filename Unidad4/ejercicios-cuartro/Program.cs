using System;

namespace ejercicios_cuartro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 1:
                  Consigna:
            Solicitar el ingreso de dos números y luego calcular:
            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.
            Se deberá emitir un cartel por pantalla con el resultado correspondiente.

                                                               CODIGO:-------------------------------------------------------------------------------
            int n1, n2, r;
            Console.WriteLine("Ingrese dos números:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2) {
                r = n1 - n2;
            }else if(n1 < n2) {
                r = n1 * n2;
            }else{
                r = n1 + n2;
            }
            Console.WriteLine("El resultado es: " + r); 
------------.---------------------------------------------FIN EJERCICIO 1.*/

            /*Ejercicio 2:
                 Consigna:
            Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:
            .
            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            .
            Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..

                                                                    CODIGO:-------------------------------------------------------------------------------
            int l;
            float t, impt;

            Console.WriteLine("Ingrese el importe total de la venta:");
            impt = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros comprados:");
            l = int.Parse(Console.ReadLine());

            if (l > 500)
            {
                t = impt * 0.75f;
            }
            else if (l > 300)
            {
                t = impt * 0.85f;
            }
            else if (l > 100)
            {
                t = impt * 0.9f;
            }
            else
            {
                t = impt;
            }
            Console.WriteLine("El total a pagar es: $" + t);
------------.----------------------------------------------------FIN DE EJERCICIO DOS. */


            /*EJERCICIO 3:
                 Consigna:
            Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
                        i5 (1)	    i7 (2)	    i9 (3)
            8 RAM (1)	USD 800	    USD 900	    USD 1200
            16 RAM (2)	USD 900	    USD 1000	USD 1400
            32 RAM (3)	USD 1000	USD 1400	USD 2000
            Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

                                                                     CODIGO:-------------------------------------------------------------------------------
            int cpu, ram, monto, disc;

            Console.WriteLine("Ingrese el número de procesador:");
            cpu = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de memoria ram:");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese '1' si quiere extender el disco duro a 1TB:");
            disc = int.Parse(Console.ReadLine());

            switch(cpu) {
                case 1:
                    switch(ram) {
                        case 1:
                            monto = 800;
                            break;
                        case 2:
                            monto = 900;
                            break;
                        case 3:
                            monto = 1000;
                            break;
                        default:
                            monto = 0;
                            break;
                    }
                    break;

                case 2:
                    switch(ram){
                        case 1:
                            monto = 900;
                            break;
                        case 2:
                            monto = 1000;
                            break;
                        case 3:
                            monto = 1400;
                            break;
                        default:
                            monto = 0;
                            break;
                    }
                    break;
                case 3:
                    switch(ram){
                        case 1:
                            monto = 1200;
                            break;
                        case 2:
                            monto = 1400;
                            break;
                        case 3:
                            monto = 2000;
                            break;
                        default:
                            monto = 0;
                            break;
                    }
                    break;
                default:
                    monto = 0;
                    break;
            }
            if (disc == 1) {
                monto += 300;
            }
            Console.WriteLine("El monto total de la pc armada es: $" + monto);
------------.-----------------------------------------------------FIN DE EJERCICIO DOS.  */

            /*EJERCICIO 4:
                 Consigna:
                Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.
                                                                     CODIGO:-------------------------------------------------------------------------------
                int n1, n2, n3;

                Console.WriteLine("Ingrese 1 número:");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 1 número:");
                n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese 1 número:");
                n3 = int.Parse(Console.ReadLine());

                if ((n1 + n2) > (n2 * n3)) {
                    Console.WriteLine("La suma es mayor al roducto.");
                }
                    else {
                        Console.WriteLine("La suma no es mayor al producto.");
                    }
------------.-----------------------------------------------------FIN DE EJERCICIO DOS.  */

            /* EJERCICIO CINCO 
            int n1, n2, n3, n4;

            Console.WriteLine("Ingrese un número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número:");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3 && n3 > n4){
                Console.WriteLine("Estan ordenados de mayor a menor");
            }
                else {
                    Console.WriteLine("No estan ordenados de forma decreciente.");
                }
            CONSIGNA: Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .*/


        }
    }
}
