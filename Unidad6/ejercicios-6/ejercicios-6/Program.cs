using System;

namespace ejercicios_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Consigna 1: Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.
            /*Código: 
            int n, contPrimos, cont;
            contPrimos = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                cont = 0;
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0){
                        cont++;
                    }
                }
                if (cont == 2) {
                    contPrimos++;
                }
            }
            Console.WriteLine(contPrimos + " de los números son primos.");
            Fin del código. */

            // Consigna 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            // El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
            /* Comienzo de código
            int n, nAnterior, contImp, porcentajeImp, cont, mayorPorcentaje, grupoMPorcentaje, contOrd;
            bool bandera = false, bOrden;
            contOrd = 0;
            mayorPorcentaje = 0;
            grupoMPorcentaje = 0;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                cont = 0;
                contImp = 0;
                bOrden = true;
                nAnterior = n;
                while (n != 0)
                {
                    cont++;
                    if (n % 2 != 0){
                        contImp++;
                    }
                    
                    if (nAnterior < n){
                        bOrden = false;
                    }
                    nAnterior = n;
                    Console.WriteLine("Ingrese un número:");
                    n = int.Parse(Console.ReadLine());
                }
                porcentajeImp = (contImp * 100) / cont;
                if (!bandera){
                    bandera = true;
                    mayorPorcentaje = porcentajeImp;
                    grupoMPorcentaje = (x + 1);
                }else if(porcentajeImp > mayorPorcentaje){
                    mayorPorcentaje = porcentajeImp;
                    grupoMPorcentaje = (x + 1);
                }
                if (bOrden){
                    contOrd++;
                }
                Console.WriteLine("Siguiente lista:");
            }
            Console.WriteLine(contOrd + " de los grupos, estan ordenados de mayor a menor.");
            Console.WriteLine("El grupo con mayor porcentaje de impares es: " + grupoMPorcentaje + ". Con un " + mayorPorcentaje + "%.");
            Fin del código. */


            //Consigna 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. 
            //Luego mostrar cuántos números tiene cada lista.
            /* Comienzo del código:
            Fin del código. */

            int n, cont;
            

            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            while (n >= 0)
            {
                cont = 0;
                while (n != 0)
                {
                    cont++;
                    Console.WriteLine("Ingrese un número:");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La lista contiene: " + cont + " números. \n\nNueva Lista.");
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
            }


        }
    }
}
