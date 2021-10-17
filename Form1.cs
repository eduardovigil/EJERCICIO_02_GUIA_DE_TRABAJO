using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_02_GUIA_DE_TRABAJO
{
    public partial class Form1 : Form
    {
        Libro mylibro = new Libro();

        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            mylibro.ISBN = txtisbn.Text;
            mylibro.Titulo = txttitulo.Text;
            mylibro.Autor = txtautor.Text;
            mylibro.Numerodepaginas =Convert.ToInt32( txtnumero.Text);
            Limpiar();
        }
        private void Limpiar()
        {
            txtautor.Clear();
            txtisbn.Clear();
            txtnumero.Clear();
            txttitulo.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         

        public override string ToString()
        {
            return " El libro  "   +   mylibro.Titulo     +      "   Con ISBN    "    +     mylibro.ISBN  +    "     creado por el autor:   "     +      mylibro.Autor   +       "    tiene   "   +   mylibro.Numerodepaginas   +  " paginas";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtmonstar.Text = ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }







}
