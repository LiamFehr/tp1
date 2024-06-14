namespace Guia12._1_parte3
{
    partial class Datos_del_contenedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbid = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.updanwid = new System.Windows.Forms.NumericUpDown();
            this.updawnpeso = new System.Windows.Forms.NumericUpDown();
            this.cbOrigenPais = new System.Windows.Forms.ComboBox();
            this.lbpaisorigen = new System.Windows.Forms.Label();
            this.lbpeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updanwid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updawnpeso)).BeginInit();
            this.SuspendLayout();
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(29, 42);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(16, 13);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "Id";
            // 
            // btAgregar
            // 
            this.btAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAgregar.Location = new System.Drawing.Point(110, 179);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(131, 37);
            this.btAgregar.TabIndex = 3;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // updanwid
            // 
            this.updanwid.Location = new System.Drawing.Point(161, 42);
            this.updanwid.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updanwid.Name = "updanwid";
            this.updanwid.Size = new System.Drawing.Size(157, 20);
            this.updanwid.TabIndex = 4;
            this.updanwid.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // updawnpeso
            // 
            this.updawnpeso.Location = new System.Drawing.Point(161, 135);
            this.updawnpeso.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.updawnpeso.Name = "updawnpeso";
            this.updawnpeso.Size = new System.Drawing.Size(157, 20);
            this.updawnpeso.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.cbOrigenPais.FormattingEnabled = true;
            this.cbOrigenPais.Items.AddRange(new object[] {
            "Argentina",
            "Alemania",
            "Croacia",
            "China",
            "Turquia"});
            this.cbOrigenPais.Location = new System.Drawing.Point(161, 89);
            this.cbOrigenPais.Name = "comboBox1";
            this.cbOrigenPais.Size = new System.Drawing.Size(157, 21);
            this.cbOrigenPais.TabIndex = 6;
            // 
            // lbpaisorigen
            // 
            this.lbpaisorigen.AutoSize = true;
            this.lbpaisorigen.Location = new System.Drawing.Point(29, 97);
            this.lbpaisorigen.Name = "lbpaisorigen";
            this.lbpaisorigen.Size = new System.Drawing.Size(74, 13);
            this.lbpaisorigen.TabIndex = 7;
            this.lbpaisorigen.Text = "Pais de origen";
            // 
            // lbpeso
            // 
            this.lbpeso.AutoSize = true;
            this.lbpeso.Location = new System.Drawing.Point(29, 142);
            this.lbpeso.Name = "lbpeso";
            this.lbpeso.Size = new System.Drawing.Size(31, 13);
            this.lbpeso.TabIndex = 8;
            this.lbpeso.Text = "Peso";
            // 
            // Datos_del_contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 252);
            this.Controls.Add(this.lbpeso);
            this.Controls.Add(this.lbpaisorigen);
            this.Controls.Add(this.cbOrigenPais);
            this.Controls.Add(this.updawnpeso);
            this.Controls.Add(this.updanwid);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lbid);
            this.Name = "Datos_del_contenedor";
            this.Text = "Datos_del_contenedor";
            ((System.ComponentModel.ISupportInitialize)(this.updanwid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updawnpeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.NumericUpDown updanwid;
        public System.Windows.Forms.NumericUpDown updawnpeso;
        public System.Windows.Forms.ComboBox cbOrigenPais;
        public System.Windows.Forms.Button btAgregar;
        public System.Windows.Forms.Label lbid;
        public System.Windows.Forms.Label lbpaisorigen;
        public System.Windows.Forms.Label lbpeso;
    }
}