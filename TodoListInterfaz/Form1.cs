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

        private void btnA�adirTarea_Click(object sender, EventArgs e)
        {
            // Obtener la descripci�n de la tarea del TextBox
            string descripcion = txtDescripcionTarea.Text;

            // Verificar que la descripci�n no est� vac�a
            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                // Crear una nueva instancia de Tarea
                Tarea nuevaTarea = new Tarea(descripcion);

                // A�adir la tarea a la lista
                tareas.Add(nuevaTarea);

                // A�adir la descripci�n de la tarea al ListBox
                listBoxTareas.Items.Add(nuevaTarea.Descripcion);

                // Limpiar el TextBox
                txtDescripcionTarea.Clear();
            }
        }

    }
}
