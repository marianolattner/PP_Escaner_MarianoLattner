using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Informes
    {

        // muestra la cantidad de documentos que hay por estado, la cantidad de paginas o de superficie y todos los datos del ToString del documento
        private static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {
            extension = 0;
            cantidad = 0;
            var resumenBuilder = new StringBuilder();
            foreach (var doc in e.ListaDocumentos)
            {
                if (doc.Estado == estado)
                {
                    cantidad ++;

                    if (doc is Libro libro)
                    {
                        extension += libro.NumPaginas;
                    }
                    else if (doc is Mapa mapa)
                    {
                        extension += mapa.Superficie;
                    }
                        resumenBuilder.AppendLine(doc.ToString());
                }
            }
            resumenBuilder.AppendLine($"en la fila de: {estado}");
            resumenBuilder.AppendLine($"Cantidad total de documentos: {cantidad}");
            resumenBuilder.AppendLine($"Extensión total: {extension}");

            resumen = resumenBuilder.ToString();
        }

        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.Distribuido, out  extension, out  cantidad, out  resumen);
        }

        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnEscaner, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Documento.Paso.Terminado, out extension, out cantidad, out resumen);
        }
    }
}
