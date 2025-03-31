using System.Windows.Forms;
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

            // Asegurarse que la descripción no esté vacía
            if (!string.IsNullOrWhiteSpace(descripcion))
            {
                // Crear una nueva instancia de Tarea
                Tarea nuevaTarea = new Tarea(descripcion);

                // Añadir la tarea a la lista del objeto
                tareas.Add(nuevaTarea);

                // Crear un nuevo Label para la tarea
                Label lblTarea = new Label();
                lblTarea.Text = nuevaTarea.Descripcion;
                lblTarea.AutoSize = true;

                // Añadir el Label al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(lblTarea);

                // Limpiar el TextBox
                txtDescripcionTarea.Clear();

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
