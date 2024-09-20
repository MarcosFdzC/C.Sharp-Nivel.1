using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)/* Esto es la cabecera de la función principal */
        {
            //Partes de la función:
            //CABECERA contine: 
                //1.Tipo de dato
                //2.Nombre con las mismas reglas que cualquier variable
                //3.Opcional: parámetros
            //CUERPO:  
                //1.Definición/Lógica
                //2.Opcional: retorno de valor/resultado


                //lógica
                //resultado = n1 + n2;
                /* llamado a la función */
                /* parámetros mandados por valor */
                resultado = sumar(n1, n2/*parámetros*/);
                //fin lógica

                /* parámetros mandados por referencia */
                resultado = sumar (ref n1,ref n2/* parámetros por referencia */);
                /* antes de cada variable añadimos ref */

                console.WriteLine("El resultado es: " + resultado);
                Console.WriteLine("El resultado es: " + sumar( n1, n2))
                //SCOPE
        }

        //DECLARACIÓN DE LA FUNCIÓN
        static int sumar(int a, int b/*argumento*/)/* por valor */
        static int sumar(ref int a, ref int b)/* por referencia */ /* antes del tipo de dato añadimos ref. */
        /* el argumento son la cantidad y que tipo de datos voy a recibir. */
        {
            int r;
            r = a + b + 2;
            return r;
        }
    }
}
