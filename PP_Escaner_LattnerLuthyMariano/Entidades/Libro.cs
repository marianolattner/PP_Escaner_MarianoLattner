using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        int numPaginas;

        public string ISBN
        {
            get { return NumNormalizado; }
        }

        public int NumPaginas
        {
            get { return numPaginas; }
        }

        public Libro(string titulo, string autor, int anio, string numNormalizado, string codebar, int numPaginas)
            : base(titulo, autor, anio, numNormalizado, codebar)
        {
            this.numPaginas = numPaginas;

        }

        //sobrecarga del operador ==

        public static bool operator ==(Libro l1, Libro l2)
        {
            // Comparo si tienen el mismo barcode, ISBN o título y autor
            return l1.Barcode == l2.Barcode || l1.ISBN == l2.ISBN ||
                   (l1.Titulo == l2.Titulo && l1.Autor == l2.Autor);
        }

        //sobrecarga del operador !=

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append(base.ToString());
            text.AppendLine($"ISBN: {ISBN}");
            text.AppendLine($"Cód. de barras: {Barcode}");
            text.AppendLine($"Número de páginas: {NumPaginas}");
            return text.ToString();
        }

    }
}
