using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            //*Obtenemos el nombre ingresado y eliminamos espacios en blanco adicionales*//
            string nombreCompleto = tbNombres.Text.Trim();

            //* Validamos que el nombre no este vacio*//
            if (string.IsNullOrEmpty(nombreCompleto))
            {
                MessageBox.Show("El nombre no puede estar vacio, ingresar nombres");
                return;
            }

            //* Validamos que el nombre no contenga numeros *//
            if (nombreCompleto.Any(char.IsDigit))
            {
                MessageBox.Show("El nombre no puede contener numeros");
                return;
            }

            if (contador < 25)
            {
                //Guardar el nombre ingresado en el arreglo
                estudiantes[contador] = tbNombres.Text;
                contador++;
                tbNombres.Clear();

                //opcional: mostrar mensaje que los nombres se han agg correctamente
                lblMensaje.Text = $"Nombre de estudiante {contador} agregador correctamente";

                //Si ya se ingreso el maximo 25, se desactivara el boton y se notificara
                if (contador == 25)
                {
                    btnAgregar.Enabled = false;
                    MessageBox.Show("Se ha alcanzado el maximo de nombres, 25");
                    return;
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            tbResultadoNombres.Clear(); //Se limpia el cuadro de resultados

            bool hayNombreLargos = false;

            //Recorrre el arreglo en busca de los nombres con mas de 25 caracteres
            for (int i = 0; i < estudiantes.Length; i++) 
            {
                if (estudiantes[i] != null && estudiantes[i].Length > 25) 
                {
                    tbResultadoNombres.AppendText(estudiantes[i] + Environment.NewLine + Environment.NewLine);

                    hayNombreLargos |= true;
                }
            }   if (!hayNombreLargos) 
                {
                tbResultadoNombres.Text = "No hay nombres con mas de 25 caracteres";
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
