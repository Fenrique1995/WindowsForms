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
            labelTitulo.Font = new Font(labelTitulo.Font, FontStyle.Bold | FontStyle.Italic);
            labelTitulo.Font = new Font(labelTitulo.Font.FontFamily, 14);
            labelMensaje.Font = new Font(labelMensaje.Font.FontFamily, 12);
        }
    }
}
