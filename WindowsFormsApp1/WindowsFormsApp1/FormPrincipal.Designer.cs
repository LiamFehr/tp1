namespace WindowsFormsApp1
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
            this.btnAgregarCompetidor = new System.Windows.Forms.Button();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.btResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCompetidor
            // 
            this.btnAgregarCompetidor.Location = new System.Drawing.Point(81, 37);
            this.btnAgregarCompetidor.Name = "btnAgregarCompetidor";
            this.btnAgregarCompetidor.Size = new System.Drawing.Size(176, 31);
            this.btnAgregarCompetidor.TabIndex = 0;
            this.btnAgregarCompetidor.Text = "Agregar Competidor";
            this.btnAgregarCompetidor.UseVisualStyleBackColor = true;
            this.btnAgregarCompetidor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTiempo
            // 
            this.btnTiempo.Location = new System.Drawing.Point(81, 87);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(176, 31);
            this.btnTiempo.TabIndex = 1;
            this.btnTiempo.Text = "Cargar Tiempos de competidores";
            this.btnTiempo.UseVisualStyleBackColor = true;
            this.btnTiempo.Click += new System.EventHandler(this.btnTiempo_Click);
            // 
            // btResultados
            // 
            this.btResultados.Location = new System.Drawing.Point(81, 139);
            this.btResultados.Name = "btResultados";
            this.btResultados.Size = new System.Drawing.Size(176, 31);
            this.btResultados.TabIndex = 2;
            this.btResultados.Text = "Resultados";
            this.btResultados.UseVisualStyleBackColor = true;
            this.btResultados.Click += new System.EventHandler(this.btResultados_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 208);
            this.Controls.Add(this.btResultados);
            this.Controls.Add(this.btnTiempo);
            this.Controls.Add(this.btnAgregarCompetidor);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCompetidor;
        private System.Windows.Forms.Button btnTiempo;
        private System.Windows.Forms.Button btResultados;
    }
}

