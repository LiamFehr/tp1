namespace Actividad1
{
    partial class Form1
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
            this.Crear = new System.Windows.Forms.Button();
            this.Reponer = new System.Windows.Forms.Button();
            this.Tomar = new System.Windows.Forms.Button();
            this.CantHarina = new System.Windows.Forms.TextBox();
            this.CantFrutas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(31, 43);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 23);
            this.Crear.TabIndex = 0;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // Reponer
            // 
            this.Reponer.Location = new System.Drawing.Point(31, 88);
            this.Reponer.Name = "Reponer";
            this.Reponer.Size = new System.Drawing.Size(75, 23);
            this.Reponer.TabIndex = 1;
            this.Reponer.Text = "Reponer ";
            this.Reponer.UseVisualStyleBackColor = true;
            this.Reponer.Click += new System.EventHandler(this.Reponer_Click);
            // 
            // Tomar
            // 
            this.Tomar.Location = new System.Drawing.Point(31, 209);
            this.Tomar.Name = "Tomar";
            this.Tomar.Size = new System.Drawing.Size(75, 23);
            this.Tomar.TabIndex = 2;
            this.Tomar.Text = "Tomar";
            this.Tomar.UseVisualStyleBackColor = true;
            this.Tomar.Click += new System.EventHandler(this.Tomar_Click);
            // 
            // CantHarina
            // 
            this.CantHarina.Location = new System.Drawing.Point(31, 144);
            this.CantHarina.Name = "CantHarina";
            this.CantHarina.Size = new System.Drawing.Size(100, 20);
            this.CantHarina.TabIndex = 3;
            // 
            // CantFrutas
            // 
            this.CantFrutas.Location = new System.Drawing.Point(31, 170);
            this.CantFrutas.Name = "CantFrutas";
            this.CantFrutas.Size = new System.Drawing.Size(100, 20);
            this.CantFrutas.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CantFrutas);
            this.Controls.Add(this.CantHarina);
            this.Controls.Add(this.Tomar);
            this.Controls.Add(this.Reponer);
            this.Controls.Add(this.Crear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Crear;
        public System.Windows.Forms.Button Reponer;
        public System.Windows.Forms.Button Tomar;
        public System.Windows.Forms.TextBox CantHarina;
        public System.Windows.Forms.TextBox CantFrutas;
    }
}

