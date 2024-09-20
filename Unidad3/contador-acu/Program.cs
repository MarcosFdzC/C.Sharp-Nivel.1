using System;

namespace contador_acu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acumuladores y contadores:
            //Nota: los acumuladores/contadores siempre deben ser iniciados, normalmente en cero.
            //Operador de incremento: ++ (es lo mismo que poner contador = contador + 1)
            //Operador de disminucion: -- (es lo mismo que poner contador = contador - 1)
            //Operador de acumulacion: += (es lo mismo que poner acumulador = acumulador + n2)
            //Operador de disgregar: -= (es lo mismo que poner acumulador = acumulador - n2)

            //Ej: 
            int contador = 0, e1 = 20, e2 = 30, e3 = 15;
            int acumulador = 0;

            if (e1 > 18){
                contador = contador + 1;
                acumulador = acumulador + e1;
            }

            if (e2 > 18){
                contador++;
                acumulador += e2;
            }

            if (e3 > 18){
                contador++;
                acumulador += e3;
            }
            Console.WriteLine("El conteo es:" + contador + " - El acumulador es:"
            + acumulador);
        }
    }
}
