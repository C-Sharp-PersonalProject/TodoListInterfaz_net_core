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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(285, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(149, 429);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 429);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
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
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
