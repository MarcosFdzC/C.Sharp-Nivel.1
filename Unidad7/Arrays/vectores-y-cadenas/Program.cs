using System;

namespace arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrelgos, array o vectores.

            /* Arreglos INT.
            int a;
            int [] numeros = new int [10];
            numeros [6] = 1;
            numeros [0] = 7;
            numeros [7] = 32450;
            a = numeros [6] + numeros[0] + numeros [7];
            Console.WriteLine ("numeros[0]");
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la nota:");
                numeros[x] = int.Parse(Console.ReadLine()); 
                }*/

            /* Arreglos tipo double/float 
            double[] muestraMatutina = new double [31];
            double[] muestraVespertina = new double [31];
            double[] muestraNocturna = new double [31];
            */

            //----------- CADENA DE CARACTERES: ---------------------------------------------------------------------------------
            // CADENA DE CARACTERES, VECTOR DE CHAR Y STRING SON 3 COSAS DIFERENTES. TIENEN UNA DIFERENCIA CONCEPTUAL.


            /* 
            STRING: todavia no se xdd

            CADENA DE CARACTERES: LA CADENA GUARDA UN REGISTRO DE CARACTERES QUE TODOS JUNTOS CONFORMAN UNA FRASE COMPLETA.
            EJEMPLO: H O L A   C O M O   E S T A S . \0 (esto es una cadena de vectores con 16 espacios ocupados, porque los espacios entre palabra y palabra tambien ocupan un espacio del indice. Incluso el \0(aunque sean dos caracteres, en la programación es tomado como solo un caracter) necesita su espacio para ser guardado)
            
            VECTOR DE CHAR: BASICAMENTE GUARDA UNICAMENTE UN CARACTER POR INDICE, ESE CARACTER INDIVIDUAL SERÁ UN DATO, ES DECIR UN REGISTRO CON SIGNIFICADO. EJEMPLO: P = PRESENTE A = AUSENTE N = NO SE
             */

            char[] cadena = new char[10];
        
            cadena[x] = char.Parse(Console.ReadLine());

        }
    } 
}
