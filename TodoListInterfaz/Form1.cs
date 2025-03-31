using TodoListInterfaz.clases;

namespace TodoListInterfaz
{
    public partial class Form1 : Form
    {
        private List<Tarea> tareas = new List<Tarea>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAñadirTarea_Click(object sender, EventArgs e)
        {
            // Obtener la descripción de la tarea del TextBox
            string descripcion = txtDescripcionTarea.Text;

            // Verificar que la descripción no esté vacía
            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                // Crear una nueva instancia de Tarea
                Tarea nuevaTarea = new Tarea(descripcion);

                // Añadir la tarea a la lista
                tareas.Add(nuevaTarea);

                // Añadir la descripción de la tarea al ListBox
                listBoxTareas.Items.Add(nuevaTarea.Descripcion);

                // Limpiar el TextBox
                txtDescripcionTarea.Clear();
            }
        }

    }
}
