using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoRevistas2
{
    class Program
    {
        // Lista que actúa como el catálogo de revistas
        // Se utiliza una lista de strings para almacenar los títulos de las revistas
        static List<string> catalogoRevistas = new List<string>();

        static void Main(string[] args)
        {
            IngresarTitulos(); // Llamada al método que permite ingresar 10 títulos de revistas
            Menu();            // Llamada al método que muestra el menú interactivo para realizar operaciones
        }

        // Método para ingresar 10 títulos de revistas al catálogo
        static void IngresarTitulos()
        {
            // Imprime un mensaje solicitando al usuario que ingrese 10 títulos
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("+===++++++++++++++++++++++++++++++===+");
            Console.WriteLine("+                                    +");
            Console.WriteLine("+    Ingrese 10 títulos de revistas  +");
            Console.WriteLine("+                                    +");
            Console.WriteLine("+===++++++++++++++++++++++++++++++===+");
            // Un ciclo for se utiliza para ingresar 10 títulos en la lista
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("**************************************");
                Console.Write($"Título {i + 1}: "); // Pide el título al usuario
                string titulo = Console.ReadLine(); // Lee el título ingresado por el usuario
                catalogoRevistas.Add(titulo); // Agrega el título a la lista 'catalogoRevistas'                
            }
        }

        // Método que muestra el menú interactivo
        static void Menu()
        {
            int opcion = 0; // Variable para almacenar la opción seleccionada por el usuario
            do
            {
                // Limpia la pantalla para mostrar el menú de forma más clara
                Console.Clear();
                // Muestra las opciones del menú
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("+===+++++++++++++++++++++++++++++++===");
                Console.WriteLine("+                                    +");
                Console.WriteLine("+== Menú del Catálogo de Revistas ===+");
                Console.WriteLine("+                                    +");
                Console.WriteLine("+1. Buscar un título                 +");  // Opción para buscar un título
                Console.WriteLine("+2. Salir                            +");             // Opción para salir del programa
                Console.WriteLine("+                                    +");
                Console.WriteLine("+===+++++++++++++++++++++++++++++++===");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Seleccione una opción: ");  // Pide al usuario que elija una opción
                opcion = int.Parse(Console.ReadLine());    // Convierte la entrada del usuario a entero

                // Estructura switch para ejecutar la opción seleccionada por el usuario
                switch (opcion)
                {
                    case 1:
                        BuscarTitulo(); // Llama al método para buscar un título
                        break;
                    case 2:
                        Console.WriteLine("Saliendo..."); // Muestra un mensaje de salida
                        break;
                    default:
                        Console.WriteLine("Opción no válida."); // Muestra un mensaje si la opción no es válida
                        break;
                }

                // Si la opción no es 2 (Salir), pide al usuario que presione una tecla para continuar
                if (opcion != 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();  // Espera a que el usuario presione una tecla
                }

            } while (opcion != 2); // El ciclo se repite hasta que el usuario elija salir (opción 2)
        }

        // Método que realiza una búsqueda iterativa en el catálogo de revistas
        static void BuscarTitulo()
        {
            // Pide al usuario que ingrese el título que desea buscar
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Ingrese el título que desea buscar: ");
            string tituloBuscado = Console.ReadLine();  // Lee el título que el usuario quiere buscar
            bool encontrado = false;  // Variable booleana para saber si se encontró el título

            // Búsqueda iterativa: se recorre la lista de títulos con un foreach
            foreach (var titulo in catalogoRevistas)
            {
                // Compara el título ingresado con cada título de la lista, ignorando mayúsculas/minúsculas
                if (titulo.Equals(tituloBuscado, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true; // Si encuentra el título, establece la variable 'encontrado' en true
                    break;  // Sale del bucle una vez encontrado el título
                }
            }

            // Condicional para mostrar si el título fue encontrado o no
            if (encontrado)
            {
                // Muestra un mensaje de que el título fue encontrado
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Título \"{tituloBuscado}\" encontrado.");
            }
            else
            {
                // Muestra un mensaje de que el título no fue encontrado
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Título \"{tituloBuscado}\" no encontrado.");
            }
        }
    }
}
