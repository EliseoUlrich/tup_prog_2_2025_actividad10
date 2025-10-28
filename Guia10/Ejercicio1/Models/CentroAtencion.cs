using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio1.Models
{
    public class CentroAtencion
    {
        LinkedList<Solicitud> solicitudesPendientes = new LinkedList<Solicitud>();
        Queue<Solicitud> colaDeAtencion = new Queue<Solicitud>();
        Stack<Resolucion> pilaHistorica = new Stack<Resolucion>();

        public void ImportarCsvSolicitudesEntrantes(Stream fs)
        { 
            StreamReader reader = new StreamReader(fs);

            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();
                
                Solicitud solicitud = new Solicitud();
                solicitud.Importar(linea);
                solicitudesPendientes.AddLast(solicitud);
            }
            reader.Close();
        }

        public LinkedListNode<Solicitud> GetSolitudePendiente()
        {
            if(solicitudesPendientes.Count>0)
            return solicitudesPendientes.First;
            return null;
        }
        public void Atender(Solicitud solicitud)
        { 
            LinkedListNode<Solicitud> nodo = solicitudesPendientes.Find(solicitud);

            if(nodo!=null)
            {
                solicitudesPendientes.Remove(nodo);
            }
            colaDeAtencion.Enqueue(solicitud);
        }
        public string[] VerDescripcionColaAtencion()
        {
            string[] descripciones = new string[colaDeAtencion.Count];
            int n = 0;
            foreach (Solicitud solicitud in colaDeAtencion)
            {
                descripciones[n++] = solicitud.ToString();
            }
            return descripciones;
        }
        public void ResolverSolitudEnEspera()
        { 
            if(colaDeAtencion.Count>0)
            {
                Solicitud solicitud = colaDeAtencion.Dequeue();
                string descripcion = $"Resuelta! muchas gracias, vuelva pronto!!";
                Resolucion resolucion = new Resolucion(descripcion, solicitud);
                pilaHistorica.Push(resolucion); 
            }
        }
        public string[] VerDescripcionPilaHistorica()
        {
            string[] descripciones = new string[pilaHistorica.Count];
            int n = 0;
            foreach (Resolucion resolucion in pilaHistorica)
            {
                descripciones[n++] = resolucion.ToString();
            }
            return descripciones;
        }
        public void ExportarCsvHistorialResoluciones(FileStream fs)
        { 
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Descripción Resolución; Número de Solicitud; Descripción Solicitud");
            foreach (Resolucion resolucion in pilaHistorica)
            { 
                sw.WriteLine(resolucion.ToString());
            }
            sw.Close();
        }

    }
}
