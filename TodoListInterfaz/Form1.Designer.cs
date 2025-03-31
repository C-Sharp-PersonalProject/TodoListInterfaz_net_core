namespace TodoListInterfaz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDescripcionTarea = new TextBox();
            label1 = new Label();
            listBoxTareas = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDescripcionTarea
            // 
            txtDescripcionTarea.Location = new Point(24, 83);
            txtDescripcionTarea.Name = "txtDescripcionTarea";
            txtDescripcionTarea.Size = new Size(243, 27);
            txtDescripcionTarea.TabIndex = 0;
            txtDescripcionTarea.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 60);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre de la Tarea";
            // 
            // listBoxTareas
            // 
            listBoxTareas.Location = new Point(404, 60);
            listBoxTareas.Name = "listBoxTareas";
            listBoxTareas.Size = new Size(367, 350);
            listBoxTareas.TabIndex = 2;
            listBoxTareas.UseCompatibleStateImageBehavior = false;
            listBoxTareas.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(24, 137);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Guardar Tarea";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAñadirTarea_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 429);
            Controls.Add(button1);
            Controls.Add(listBoxTareas);
            Controls.Add(label1);
            Controls.Add(txtDescripcionTarea);
            Name = "Form1";
            Text = "Todo List Prueba";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcionTarea;
        private Label label1;
        private ListView listBoxTareas;
        private Button button1;
    }
}
