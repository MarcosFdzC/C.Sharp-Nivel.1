using System;

namespace ejercicios_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Consigna 1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.
------------Código:
            int precio, cant;

            Console.WriteLine("Ingrese el precio del artículo:");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida del artículo:");
            cant = int.Parse(Console.ReadLine());

            Console.WriteLine("El monto total a pagar es: $" + producto(precio, cant));
            static int producto( int n1, int n2){
                return = n1 * n2;
            }
------------Fin del código.*/


            /* Consigna 2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o 0 si no lo es. Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.
------------Código:
            int n, cantPar = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if (par(n) == 1)
                    cantPar++;
            }
            Console.WriteLine("La cantidad de números par es: " + cantPar);
            static int par(int n)
            {
                int r = 0;
                if (n % 2 == 0)
                {
                    r = 1;
                }
                return r;
            }
------------Fin del código.*/



            /* Consigna 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
------------Código:
            int n, acu = 0, cont = 0, prom;
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            while(n != 0)
            {
                if (primo(n) == 1)
                {
                    acu += n;
                    cont++;
                }
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            }
            prom = acu / cont;
            Console.WriteLine("El promedio de los números primos es: " + prom);
            static int primo(int n)
            {
                int r = 0, cont = 0;
                for (int x = 1; x <= n; x++)
                {
                    if (n % x == 0){
                        cont++;
                    }
                }
                if(cont == 2)
                    r = 1;
                return r;
            }
------------Fin del código.*/

            /* Consigna 4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:
            a. 1 si el número es positivo.
            b. -1 si el número es negativo.
            c. 0 si el número es cero.

------------Código:
------------Fin del código.*/
            int n, n2 = 0;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n, ref n2);

            Console.WriteLine("El número es: " + n2);

        }
        static void positivoNegativoCero(int n, ref int n2)
        {
            if(n > 0)
            {
                n2 = 1;
            }else if(n < 0)
                {
                    n2 = -1;
                }
        }

    }
}
