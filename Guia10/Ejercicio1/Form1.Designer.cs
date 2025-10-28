namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBSolicitudes = new System.Windows.Forms.GroupBox();
            this.gBHistorial = new System.Windows.Forms.GroupBox();
            this.btnImportarSolicitudes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lsbVerSolicitudesImportadas = new System.Windows.Forms.ListBox();
            this.lbSolicitudSeleccionada = new System.Windows.Forms.Label();
            this.btnConfirmarAtencion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbColaSolitudesAAtender = new System.Windows.Forms.ListBox();
            this.btnResolverSolicitud = new System.Windows.Forms.Button();
            this.lsbHistorialResoluciones = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gBSolicitudes.SuspendLayout();
            this.gBHistorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBSolicitudes
            // 
            this.gBSolicitudes.Controls.Add(this.btnResolverSolicitud);
            this.gBSolicitudes.Controls.Add(this.lsbColaSolitudesAAtender);
            this.gBSolicitudes.Controls.Add(this.label2);
            this.gBSolicitudes.Controls.Add(this.btnConfirmarAtencion);
            this.gBSolicitudes.Controls.Add(this.lbSolicitudSeleccionada);
            this.gBSolicitudes.Controls.Add(this.lsbVerSolicitudesImportadas);
            this.gBSolicitudes.Controls.Add(this.label1);
            this.gBSolicitudes.Controls.Add(this.btnImportarSolicitudes);
            this.gBSolicitudes.Location = new System.Drawing.Point(13, 13);
            this.gBSolicitudes.Name = "gBSolicitudes";
            this.gBSolicitudes.Size = new System.Drawing.Size(566, 274);
            this.gBSolicitudes.TabIndex = 0;
            this.gBSolicitudes.TabStop = false;
            this.gBSolicitudes.Text = "Atención de Solicitudes";
            // 
            // gBHistorial
            // 
            this.gBHistorial.Controls.Add(this.label3);
            this.gBHistorial.Controls.Add(this.lsbHistorialResoluciones);
            this.gBHistorial.Controls.Add(this.button2);
            this.gBHistorial.Location = new System.Drawing.Point(585, 12);
            this.gBHistorial.Name = "gBHistorial";
            this.gBHistorial.Size = new System.Drawing.Size(170, 277);
            this.gBHistorial.TabIndex = 1;
            this.gBHistorial.TabStop = false;
            this.gBHistorial.Text = "Historial de Resoluciones";
            // 
            // btnImportarSolicitudes
            // 
            this.btnImportarSolicitudes.Location = new System.Drawing.Point(17, 29);
            this.btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            this.btnImportarSolicitudes.Size = new System.Drawing.Size(83, 34);
            this.btnImportarSolicitudes.TabIndex = 0;
            this.btnImportarSolicitudes.Text = "Importar Solicitudes";
            this.btnImportarSolicitudes.UseVisualStyleBackColor = true;
            this.btnImportarSolicitudes.Click += new System.EventHandler(this.btnImportarSolicitudes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exportar Resoluciones";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listas de solicitudes Entrantes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lsbVerSolicitudesImportadas
            // 
            this.lsbVerSolicitudesImportadas.FormattingEnabled = true;
            this.lsbVerSolicitudesImportadas.Location = new System.Drawing.Point(17, 104);
            this.lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            this.lsbVerSolicitudesImportadas.Size = new System.Drawing.Size(178, 147);
            this.lsbVerSolicitudesImportadas.TabIndex = 2;
            this.lsbVerSolicitudesImportadas.SelectedIndexChanged += new System.EventHandler(this.lsbVerSolicitudesImportadas_SelectedIndexChanged);
            // 
            // lbSolicitudSeleccionada
            // 
            this.lbSolicitudSeleccionada.Location = new System.Drawing.Point(201, 104);
            this.lbSolicitudSeleccionada.Name = "lbSolicitudSeleccionada";
            this.lbSolicitudSeleccionada.Size = new System.Drawing.Size(87, 30);
            this.lbSolicitudSeleccionada.TabIndex = 3;
            this.lbSolicitudSeleccionada.Text = "Seleccione desde la lista";
            // 
            // btnConfirmarAtencion
            // 
            this.btnConfirmarAtencion.Location = new System.Drawing.Point(201, 137);
            this.btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            this.btnConfirmarAtencion.Size = new System.Drawing.Size(87, 107);
            this.btnConfirmarAtencion.TabIndex = 4;
            this.btnConfirmarAtencion.Text = "Confirmar seleccion hacia cola de atención";
            this.btnConfirmarAtencion.UseVisualStyleBackColor = true;
            this.btnConfirmarAtencion.Click += new System.EventHandler(this.btnConfirmarAtencion_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(294, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cola de Atención";
            // 
            // lsbColaSolitudesAAtender
            // 
            this.lsbColaSolitudesAAtender.FormattingEnabled = true;
            this.lsbColaSolitudesAAtender.Location = new System.Drawing.Point(294, 104);
            this.lsbColaSolitudesAAtender.Name = "lsbColaSolitudesAAtender";
            this.lsbColaSolitudesAAtender.Size = new System.Drawing.Size(178, 147);
            this.lsbColaSolitudesAAtender.TabIndex = 6;
            // 
            // btnResolverSolicitud
            // 
            this.btnResolverSolicitud.Location = new System.Drawing.Point(479, 110);
            this.btnResolverSolicitud.Name = "btnResolverSolicitud";
            this.btnResolverSolicitud.Size = new System.Drawing.Size(75, 40);
            this.btnResolverSolicitud.TabIndex = 7;
            this.btnResolverSolicitud.Text = "Resolver solicitud";
            this.btnResolverSolicitud.UseVisualStyleBackColor = true;
            this.btnResolverSolicitud.Click += new System.EventHandler(this.btnResolverSolicitud_Click);
            // 
            // lsbHistorialResoluciones
            // 
            this.lsbHistorialResoluciones.FormattingEnabled = true;
            this.lsbHistorialResoluciones.Location = new System.Drawing.Point(9, 111);
            this.lsbHistorialResoluciones.Name = "lsbHistorialResoluciones";
            this.lsbHistorialResoluciones.Size = new System.Drawing.Size(151, 147);
            this.lsbHistorialResoluciones.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pila de resoluciones";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 301);
            this.Controls.Add(this.gBHistorial);
            this.Controls.Add(this.gBSolicitudes);
            this.Name = "FormPrincipal";
            this.Text = "Ejercicio 1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.gBSolicitudes.ResumeLayout(false);
            this.gBHistorial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBSolicitudes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportarSolicitudes;
        private System.Windows.Forms.GroupBox gBHistorial;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lsbVerSolicitudesImportadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmarAtencion;
        private System.Windows.Forms.Label lbSolicitudSeleccionada;
        private System.Windows.Forms.Button btnResolverSolicitud;
        private System.Windows.Forms.ListBox lsbColaSolitudesAAtender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsbHistorialResoluciones;
    }
}

