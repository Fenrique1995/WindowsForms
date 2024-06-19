namespace FormsEjercicio2
{
    public enum Materias
    {
        Programacion_II,
        Matematica,
        Estadistica
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PoblarComboBox();
        }

        private void Saludar_Click_1(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;

            if (comboBoxMaterias.SelectedItem is Materias materiaSeleccionada)
            {
                string titulo = "¡Hola, Windows Forms!";
                string mensaje = $"Soy {nombre} {apellido} y mi materia favorita es: {materiaSeleccionada}.";

                Form2 form2 = new Form2(titulo, mensaje);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una materia.");
            }
        }
        private void PoblarComboBox()
        {
            comboBoxMaterias.DataSource = Enum.GetValues(typeof(Materias)).Cast<Materias>().ToList();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaterias.SelectedItem != null)
            {
                Materias materiaSeleccionada = (Materias)comboBoxMaterias.SelectedItem;
            }
            else
            {
                comboBoxMaterias.SelectedItem = Materias.Programacion_II;
            }
            //MessageBox.Show($"Materia seleccionada: {materiaSeleccionada}");
        }
    }
}
