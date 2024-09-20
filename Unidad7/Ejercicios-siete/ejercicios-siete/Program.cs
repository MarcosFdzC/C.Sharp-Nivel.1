using System;

namespace ejercicios_siete
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /* Consigna 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector. 
-------------Código:
            int max, pos;
            int[] vector = new int[10];

            Console.WriteLine("Ingrese 10 números separados por un enter:");
            for (int x = 0; x < 10; x++)
            {
                vector[x] = int.Parse(Console.ReadLine());
            }
            max = vector[0];
            pos = 1;

            for (int x = 0; x < 10; x++)
            {
                if (vector[x] > max)
                {
                    max = vector[x];
                    pos = (x + 1);
                }
            }
            Console.WriteLine("El máximo valor es: " + max + " en la posición " + pos + ".");
             Fin del código.*/
            
            /* Consigna 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.
-------------Código:
            int prom, sumaP;
            int[] vector = new int [10];

            Console.WriteLine("Ingrese 10 números separados por un enter:");
            for (int x = 0; x < 10; x++)
            {
                vector [x] = int.Parse(Console.ReadLine());
            }
            sumaP = 0;
            for (int x = 0; x < 10; x++)
            {
                sumaP += vector[x];
            }
            prom = (sumaP / 10);
            for (int x = 0; x < 10; x++)
            {
                if (vector[x] > prom)
                    Console.WriteLine(vector[x] + " es mayor al promedio.");
            }
             Fin del código.*/


            /* Consigna 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            CADENA FUENTE: “La mar estaba serena"
            CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            CADENA RESULTADO: “Li mir estibi sereni"
-------------Código:
            char a, b;
            int i;
            char[] cadena = new char[51];

            Console.WriteLine("Ingrese 2 caracteres separados por un enter:");
            a = char.Parse(Console.ReadLine());
            b = char.Parse(Console.ReadLine());

            i = 0;
            Console.WriteLine("Ahora ingrese un máximo de 50 caracteres separados por un enter y corta con un punto '.':");
            cadena[i] = char.Parse(Console.ReadLine());
            while (cadena[i] != '.' && i < 50 )
            {
                i ++;
                cadena[i] = char.Parse(Console.ReadLine());
                if ( i == 49 || i == '.')
                    cadena[i+1] = '\0';
            }

            i = 0;
            while( cadena[i+1] != '\0' )
            {
                if (cadena[i] == a)
                {
                    cadena[i] = b;
                }
                i ++;
            }

            Console.WriteLine("Cambio el primer caracter por el segundo");
            for (int x = 0; x <= i; x++){
                if (cadena[x] == a)
                {
                    cadena[x] = b;
                    Console.WriteLine(cadena[x]);
                }else{
                    Console.WriteLine(cadena[x]);
                }
            }
             Fin del código.*/
            

            /* Consigna 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
                - Número de Artículo (1 a 15)
                - Cantidad Vendida 

                Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
                Se pide determinar e informar:
                a) El número de artículo que más se vendió en total.
                b) Los números de artículos que no registraron ventas.
                c) Cuantas unidades se vendieron del número de artículo 10.
-------------Código:
             Fin del código.*/

            int[] art = new int[15];
            int nArt, cant, max, pa;

            for(int x = 0; x < 15; x++)
            {
                art[x] = 0;
            }
            Console.WriteLine("Ingrese el número de artículo:");
            nArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida:");
            cant = int.Parse(Console.ReadLine());

            while (nArt != 0)
            {
                art[nArt - 1] += cant;
                
                Console.WriteLine("Ingrese el número de artículo:");
                nArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida:");
                cant = int.Parse(Console.ReadLine());
            }
            max = art[0];
            pa=1;
            for (int x = 0; x < 15; x++)
            {
                if (art[x] > max){
                    max = art[x];
                    pa = (x+1);
                }
                if (art[x] == 0){
                    Console.WriteLine("El articulo " + (x+1) + " no registró ventas.");
                }
                if (x == 9){
                    Console.WriteLine("En el art. 10 se vendieron: " + art[9] + " unidades.");
                }
            }
            Console.WriteLine("El artículo con más ventas fue el articulo " + pa + ". " + "Con un total de " + max + " unidades.");

        }
    }
}
