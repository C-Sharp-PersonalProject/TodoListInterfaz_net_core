using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListInterfaz.clases
{
    internal class Tarea
    {
        public string Descripcion { get; set; }
        public bool Completada { get; set; }

        public Tarea(string descripcion)
        {
            Descripcion = descripcion;
            Completada = false;
        }
    }
}
