using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        int alto;
        int ancho;

        public int Alto
        {
            get { return alto; }
        }

        public int Ancho
        {
            get { return ancho; }
        }
        public int Superficie
        {
            get { return ancho * alto; }
        }

        public Mapa(string titulo, string autor, int anio, string numNormalizado, string codebar, int ancho, int alto)
            :base(titulo, autor, anio,numNormalizado,codebar)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        // sobrecarga del operador ==

        public static bool operator ==(Mapa n1, Mapa n2) 
        {
            return   n1.Barcode == n2.Barcode || 
                    (n1.Titulo == n2.Titulo && n1.Autor == n2.Autor 
                    && n1.Anio == n2.Anio && n1.Superficie == n2.Superficie);
        }

        public static bool operator !=(Mapa n1, Mapa n2)
        {
            return !(n1 == n2);
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.Append(base.ToString());
            text.AppendLine($"Cód. de barras: {Barcode}");
            text.AppendLine($"Superficie: {alto} * {ancho} = {Superficie} cm2");
            return text.ToString();
        }
    }

}
