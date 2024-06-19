namespace FormsEjercicio2
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
            label1 = new Label();
            label2 = new Label();
            textNombre = new TextBox();
            textApellido = new TextBox();
            comboBoxMaterias = new ComboBox();
            label3 = new Label();
            Saludar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(115, 61);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(410, 61);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(115, 79);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 2;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(410, 79);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(100, 23);
            textApellido.TabIndex = 0;
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(115, 216);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(320, 23);
            comboBoxMaterias.TabIndex = 3;
            comboBoxMaterias.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(115, 198);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 4;
            label3.Text = "Materia Favorita:";
            // 
            // Saludar
            // 
            Saludar.Location = new Point(510, 198);
            Saludar.Name = "Saludar";
            Saludar.Size = new Size(121, 49);
            Saludar.TabIndex = 5;
            Saludar.Text = "Saludar";
            Saludar.UseVisualStyleBackColor = true;
            Saludar.Click += Saludar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 307);
            Controls.Add(Saludar);
            Controls.Add(label3);
            Controls.Add(comboBoxMaterias);
            Controls.Add(textApellido);
            Controls.Add(textNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "¡Hola, Windows Forms!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textNombre;
        private TextBox textApellido;
        private ComboBox comboBoxMaterias;
        private Label label3;
        private Button Saludar;
    }
}
