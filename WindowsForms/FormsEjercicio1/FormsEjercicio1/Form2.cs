using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEjercicio1
{
    public partial class Form2 : Form
    {
        public Form2(string titulo, string mensaje)
        {
            InitializeComponent();
            labelTitulo.Text = titulo;
            labelMensaje.Text = mensaje;
            labelTitulo.Font = new Font(labelTitulo.Font.FontFamily, 14, FontStyle.Bold | FontStyle.Italic);
            labelMensaje.Font = new Font(labelMensaje.Font.FontFamily, 12);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
