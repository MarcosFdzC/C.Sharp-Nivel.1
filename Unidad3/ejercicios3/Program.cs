using System;

namespace ejercicios3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* EJERCIIO 1:
            int n1; 

            Console.WriteLine("Ingrese un número:");

            n1 = int.Parse(Console.ReadLine());

            if (n1 > 10){
                Console.WriteLine("Es mayor a 10.");
            }else {
                    if(n1 < 10){
                        Console.WriteLine("Es menor a 10.");
                    }else {
                            Console.WriteLine("Es igual a 10.");
                        }
                } 
            FIN EJERCICIO 1*/



                /* EJERCICIO 2
                int n1;
                Console.WriteLine("Ingrese un número:");
                n1 = int.Parse(Console.ReadLine());

                if (n1 > 0) {
                    Console.WriteLine("Es positivo.");
                } else {
                    if (n1 < 0) {
                        Console.WriteLine("Es negrativo.");
                    }else {
                        Console.WriteLine("Es igual a 0.");
                    }
                }
                FIN EJERCICIO 2 */



                /* EJERCICIO 3
                float importecompra, importefinal;
                Console.WriteLine ("Igrese el importe de la compra:");
                importecompra = float.Parse(Console.ReadLine());
                if (importecompra > 5000) {
                    importefinal = importecompra * 0.82f;
                }else if(importecompra >= 1000){
                        importefinal = importecompra * 0.9f;
                    }else{
                        importefinal = importecompra;
                    }
                Console.WriteLine ("El importe final de la compra es: $" + importefinal);
                FIN EJERCICIO 3*/


                /* EJERCICIO 4
                float menor, n1, n2, n3, n4;
                Console.WriteLine("Ingrese cuartro números:");
                n1 = float.Parse(Console.ReadLine());
                n2 = float.Parse(Console.ReadLine());
                n3 = float.Parse(Console.ReadLine());
                n4 = float.Parse(Console.ReadLine());
                menor = n1;
                if (n2 < menor){
                    menor = n2;
                }
                if (n3 < menor){
                    menor = n3;
                }
                if (n4 < menor){
                    menor = n4;
                }
                Console.WriteLine("El menor de los números ingrsados es: " + menor + ".");
                FIN EJERCICIO 4 */



                /* EJERCICIO 5 
                int  n1, n2, n3, n4;
                Console.WriteLine("Ingrese cuartro números:");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                n3 = int.Parse(Console.ReadLine());
                n4 = int.Parse(Console.ReadLine());
                if (n1 > 100){
                    Console.WriteLine(n1 + " Es mayor a 100.");
                }else {
                    Console.WriteLine(n1 + " Es menor a 100.");
                    }
                if (n2 > 100){
                    Console.WriteLine(n2 + " Es mayor a 100.");
                }else {
                    Console.WriteLine(n2 + " Es menor a 100.");
                }
                if (n3 > 100){
                    Console.WriteLine(n3 + " Es mayor a 100.");
                }else {
                    Console.WriteLine(n3 + " Es menor a 100.");
                }
                if (n4 > 100){
                    Console.WriteLine(n4 + " Es mayor a 100.");
                }else {
                    Console.WriteLine(n4 + " Es menor a 100.");
                }
                FIN EJERCICIO 5 */

        }
    }
}
