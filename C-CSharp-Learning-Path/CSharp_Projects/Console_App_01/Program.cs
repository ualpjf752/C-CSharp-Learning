using System;

namespace Basic_Logic_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Hola desde C# y .NET!");

            // Ejemplo rápido de lógica: una lista y un bucle
            string[] lenguajes = { "C", "C#", "C++", "Java" };

            Console.WriteLine("Lenguajes que voy a practicar:");
            foreach (string lenguaje in lenguajes)
            {
                Console.WriteLine($"- {lenguaje}");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}