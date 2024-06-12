namespace FormsEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Saludar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string Titulo = "¡Hola, Windows Forms!";
            string Mensaje = $"Soy {nombre} {apellido}.";

            Form2 form2 = new Form2(Titulo,Mensaje);
            form2.ShowDialog();
        }
    }
}
