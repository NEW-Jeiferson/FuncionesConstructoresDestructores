using System;
//2

namespace FuncionesConstructoresDestructores
{
    public class Operacion
    {
        public int Suma(int a, int b) // Método para sumar dos números
        {
            // Este método recibe dos enteros, a y b, y retorna su suma.
            return a + b; // Retorna la suma de a y b
        }
        
    }

    class Program
    {
        static void Main()
        {
            Operacion operacion = new Operacion(); // Crea una instancia de la clase Operacion
            int resultado = operacion.Suma(5, 7); // Suma 5 y 7 usando el método Suma de la clase Operacion
            Console.WriteLine($"El resultado de la suma es: {resultado}"); // Imprime el resultado de la suma en la consola
            Console.ReadLine();
        }
    } 

}

   
