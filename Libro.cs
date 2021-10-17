using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_02_GUIA_DE_TRABAJO
{
    public class Libro
    {
        //Atributos
        private string isbn;
        private string titulo;
        private string autor;
        private int numeropaginas;

        //metodos
        public String ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Numerodepaginas
        {
            get { return numeropaginas; }
            set { numeropaginas = value; }
        }

        
    }
}
