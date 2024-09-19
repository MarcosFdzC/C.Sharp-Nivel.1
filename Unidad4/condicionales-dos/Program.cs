using System;

namespace condicionales_dos
{
    class Program
    {
        static void Main(string[] args)
        {

            // operador and = &&
            // operador or = ||
            // operador not = !, este operador invierte el resultado. 
            int edad = 20;
            char inicial = J;
                if(inicial == 'J' || inicial = 'H' && edad > 20) {
                    Console.WriteLine("21 OFF");
                }   /* Esto es lo mismo que decir "si inicial NO es 'J' o no es 'H'. Basicamente invierte el resultado. */
                if( !(inicial == 'J' || inicial = 'H') && edad > 20)¡


                // CONDICIONAL SWITCH
                char letra = 'A';

                switch(letra) {
                    case 'M' '':
                        //lo que necesitemos mostrar en ese caso.
                        break;
                    case 'H':
                        //codigo.
                        break;
                    case 'R':
                        //askljf
                        break;
                    default:
                        //este case es necesario en caso que la condicional no cumpla con ninguna de las opciones. Evita que se rompa el código.
                        break;
                }
                
                /* int edad = 20;

                if(edad > 21){
                    Console.WriteLine("Es mayor");
                }else if(edad < 12){
                        Console.WriteLine("Es un niño");
                }else {
                    Console.WriteLine("Es menor");
                } */

        }
    }
}
