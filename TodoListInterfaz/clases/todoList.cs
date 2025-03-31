using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListInterfaz.clases
{
    internal class todoList
    {
        private static List<Tarea> tareas = new List<Tarea>();

        public static void Inicio(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Gestor de Tareas");
                Console.WriteLine("1. Añadir tarea");
                Console.WriteLine("2. Marcar tarea como completada");
                Console.WriteLine("3. Listar tareas");
                Console.WriteLine("4. Salir");
                Console.Write("Selecciona una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AñadirTarea();
                        break;
                    case "2":
                        MarcarCompletada();
                        break;
                    case "3":
                        ListarTareas();
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        public static void AñadirTarea(string descripcion)
        {
            //Console.Write("Introduce la descripción de la tarea: ");
            //string descripcion = Console.ReadLine();
            Tarea nuevaTarea = new Tarea(descripcion);
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea añadida.");
        }

        public static void AñadirTarea()
        {
            Console.Write("Introduce la descripción de la tarea: ");
            string descripcion = Console.ReadLine();
            Tarea nuevaTarea = new Tarea(descripcion);
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea añadida.");
        }

        public static void MarcarCompletada(int indice)
        {
            if (indice >= 0 && indice < tareas.Count)
            {
                tareas[indice].Completada = true;
            }
        }
        public static void MarcarCompletada()
        {
            Console.Write("Introduce el índice de la tarea a marcar como completada: ");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < tareas.Count)
            {
                tareas[indice].Completada = true;
                Console.WriteLine("Tarea marcada como completada.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }
        }

        public static void ListarTareas()
        {
            Console.WriteLine("Lista de tareas:");
            for (int i = 0; i < tareas.Count; i++)
            {
                Tarea tarea = tareas[i];
                string estado = tarea.Completada ? "[X]" : "[ ]";
                Console.WriteLine($"{i}. {estado} {tarea.Descripcion}");
            }
        }
    }
}
