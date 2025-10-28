using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        CentroAtencion centroAtencion = new CentroAtencion();
        public FormPrincipal()
        {
            InitializeComponent();
        }
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        protected void VerSolicitudesPendientes()
        {
            lsbVerSolicitudesImportadas.Items.Clear();
            var nodoActual = centroAtencion.GetSolitudePendiente();
            while (nodoActual != null)
            {
                lsbVerSolicitudesImportadas.Items.Add(nodoActual.Value);
                nodoActual = nodoActual.Next;
            }
        }
        protected void VerSolicitudesAAtender()
        {
            lsbColaSolitudesAAtender.Items.Clear();
            lsbColaSolitudesAAtender.Items.AddRange(centroAtencion.VerDescripcionColaAtencion());
        }
        protected void VerHistoricoResoluciones()
        {
            lsbHistorialResoluciones.Items.Clear();
            lsbHistorialResoluciones.Items.AddRange(centroAtencion.VerDescripcionPilaHistorica());
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImportarSolicitudes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(openFileDialog1.InitialDirectory))
                openFileDialog1.InitialDirectory = "./";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    {
                        centroAtencion.ImportarCsvSolicitudesEntrantes(fs);
                    }
                    MessageBox.Show("Archivo importado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al importar el archivo: " + ex.Message);
                }
                finally
                {
                    fs.Close();
                }
                VerSolicitudesPendientes();
            }
        }

        private void lsbVerSolicitudesImportadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbVerSolicitudesImportadas.SelectedItems != null)
                lbSolicitudSeleccionada.Text = lsbVerSolicitudesImportadas.SelectedItem.ToString();
            else
                lbSolicitudSeleccionada.Text = "Seleccione un registro";
        }

        private void btnConfirmarAtencion_Click(object sender, EventArgs e)
        {
            Solicitud solicitudSeleccionada = lsbVerSolicitudesImportadas.SelectedItem as Solicitud;
            if (solicitudSeleccionada != null)
            {
                centroAtencion.Atender(solicitudSeleccionada);
                VerSolicitudesAAtender();
                VerSolicitudesPendientes();
                lsbVerSolicitudesImportadas.SelectedItem = null;
                lbSolicitudSeleccionada.Text = "Seleccione un registro";
            }
            else
            {
                MessageBox.Show("Debe seleccionar una solicitud para atender.");
            }
        }

        private void btnResolverSolicitud_Click(object sender, EventArgs e)
        {
            centroAtencion.ResolverSolitudEnEspera();
            VerHistoricoResoluciones();
            VerSolicitudesAAtender();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                FileStream fs = null;
                try
                {
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    centroAtencion.ExportarCsvHistorialResoluciones(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar el archivo: " + ex.Message);
                    return;
                }
                finally
                {
                    fs.Close();
                }
            }
        }
        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, centroAtencion);
            }
            finally
            {
                fs.Close();
            }
        }
        private void FormLoad(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("data.bin", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                centroAtencion = (CentroAtencion)formatter.Deserialize(fs);
            }
            catch (Exception)
            {
            }
            finally
            {
                fs.Close();
            }
            VerSolicitudesPendientes();
            VerSolicitudesAAtender();
            VerHistoricoResoluciones();
        }
    }
}
