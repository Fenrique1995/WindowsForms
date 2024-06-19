namespace FormsEjercicio1
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
            txtNombre = new Label();
            txtApellido = new Label();
            textApellido = new TextBox();
            textNombre = new TextBox();
            Saludar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtNombre.Location = new Point(78, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(56, 15);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre:";
            // 
            // txtApellido
            // 
            txtApellido.AutoSize = true;
            txtApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtApellido.Location = new Point(339, 74);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(55, 15);
            txtApellido.TabIndex = 1;
            txtApellido.Text = "Apellido:";
            // 
            // textApellido
            // 
            textApellido.Location = new Point(339, 92);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(113, 23);
            textApellido.TabIndex = 2;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(78, 92);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(113, 23);
            textNombre.TabIndex = 3;
            // 
            // Saludar
            // 
            Saludar.BackColor = SystemColors.ControlLight;
            Saludar.Location = new Point(212, 173);
            Saludar.Name = "Saludar";
            Saludar.Size = new Size(108, 50);
            Saludar.TabIndex = 4;
            Saludar.Text = "Saludar";
            Saludar.UseVisualStyleBackColor = false;
            Saludar.Click += Saludar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 259);
            Controls.Add(Saludar);
            Controls.Add(textNombre);
            Controls.Add(textApellido);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "¡Hola, Windows Forms!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNombre;
        private Label txtApellido;
        private TextBox textApellido;
        private TextBox textNombre;
        private Button Saludar;
    }
}
