using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        private string[] estudiantes = new string[25];
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();

        }

        

        private void btnAgg_Click(object sender, EventArgs e)
        {
        
            if (contador < 25)
            {
                estudiantes[contador] = tbNombres.Text;
                contador++;
                tbNombres.Clear();

                lblMensaje.Text = $"Nombre de estudiante "
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
