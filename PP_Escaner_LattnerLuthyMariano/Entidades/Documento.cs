using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Documento
    {
        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }
        //Atributos
        int anio;
        string autor;
        string barcode;
        Paso estado;
        string numNormalizado;
        string titulo;

        //Properties
        public int Anio
        {
            get { return anio; }
        }

        public string Autor
        {
            get { return autor; }
        }

        public string Barcode
        {
            get { return barcode; }
        }

       public Paso Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        protected string NumNormalizado
        {
            get { return numNormalizado; }
        }

        public string Titulo
        {
            get { return titulo; }
        }

        // Constructor
        public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
            this.estado = Paso.Inicio; // lo inicializo en inicio

        }

        // Metodos
        // avanza el estado, el cual es un enum siempre y cuando no este en terminado
        public bool AvanzarEstado()
        {
            if (estado == Paso.Terminado) 
            {
                return false;
            }
            else
            {
                estado++;
                return true;
            }
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Título: {titulo}");
            text.AppendLine($"Autor: {autor}");
            text.AppendLine($"Año: {anio}");
            return text.ToString();
        }

    }
}
