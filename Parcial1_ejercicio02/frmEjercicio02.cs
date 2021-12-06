using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_ejercicio02
{
    public partial class frmEjercicio02 : Form
    {
        public frmEjercicio02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //valido si el usuario ingresò una frase
            if(this.txtFrase.Text.Length==0)
            {
                MessageBox.Show("Por favor ingresa una frase...");
                //ubica el cursor en el cuadro de texto txtFrase
                this.txtFrase.Focus();
            }
            
            //creo el array de palabras
            string[] palabras = this.txtFrase.Text.Split(' ');
            this.lstPalabras.Items.Clear();

            //lleno el listbox con las palabras
            for(int i= 0; i<palabras.Length; i++)
            {
                if(palabras[i].Length>0)
                this.lstPalabras.Items.Add(palabras[i] + "-->" + "Caracteres: " + palabras[i].Length);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola uwu");
        }
    }
}
