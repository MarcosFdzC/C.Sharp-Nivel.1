using System;

namespace ejercicios_cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* EJERCICIO 1
            CONSIGNA:
            Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.
----------------------------------------.CODIGO:
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine((x + 1));
            }
----------------------------------------.FIN DEL EJERCICIO
             */


            /* EJERCICIO 2
            CONSIGNA:
            Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
----------------------------------------.CODIGO:
            int n, max;
            max = 0;
            n = 0; (((Aca iniciamos las variables, el compilador lo exije por si el cilo nunca entra, las variables no pueden estar vacias)))

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if (n > max) 
                    max = n;
            }
            Console.WriteLine("El número mayor es: " + max);
----------------------------------------.FIN DEL EJERCICIO
             */


            /* EJERCICIO 3
            CONSIGNA:
            Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
----------------------------------------.CODIGO:
            int e, acu, con, p;
            e = 0;
            acu = 0;
            con = 0;
            p = 0;
            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese una edad:");
                e = int.Parse(Console.ReadLine());
                if (e > 18){
                    acu += e;
                    con++;
                }
            }
            p = acu / con;
            Console.WriteLine("La edad promedio de las personas mayores a 18 es: " + p + "años.");
----------------------------------------.FIN DEL EJERCICIO
             */


            /* EJERCICIO 4
            CONSIGNA:
            Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.
----------------------------------------.CODIGO:
            int n, con;
            con = 0;
            Console.WriteLine("Ingrese un número:");
            n = int.Parse(Console.ReadLine());
            for (int x = 1; x <= n; x++){
                if ((n % x) == 0) 
                    con++;
                
            }

            if (con == 2) 
                Console.WriteLine(n + " es primo.");
                else 
                    Console.WriteLine(n + " no es primo.");
----------------------------------------.FIN DEL EJERCICIO
             */

            /* EJERCICIO 5
            CONSIGNA:
            Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.
----------------------------------------.CODIGO:
            int n, minImP, maxPar;
            bool bpar = false, bimp = false;
            minImP = 0;
            maxPar = 0;

            for (int x = 0; x < 20; x++) {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());
                if((n % 2) == 0){
                    if (!bpar){
                        maxPar = n;
                        bpar = true;
                    }else if(n > maxPar){
                        maxPar = n;
                    }
                }else if (!bimp){
                    minImP = n;
                    bimp = true;
                }else if (n < minImP){
                    minImP = n;
                }
            }
            Console.WriteLine("El máximo par es: " + maxPar + ". El mínimo impar es: " + minImP + ".");
----------------------------------------.FIN DEL EJERCICIO
             */




            /* EJERCICIO 
            CONSIGNA:
            
----------------------------------------.CODIGO:

----------------------------------------.FIN DEL EJERCICIO
             */
        }
    }
}
