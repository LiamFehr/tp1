namespace WindowsFormsApp1
{
    partial class FormResultados
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
            this.lbResult = new System.Windows.Forms.Label();
            this.listResult = new System.Windows.Forms.ListBox();
            this.btRcerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(90, 29);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(60, 13);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Resultados";
            this.lbResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(12, 64);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(218, 329);
            this.listResult.TabIndex = 1;
            // 
            // btRcerrar
            // 
            this.btRcerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRcerrar.Location = new System.Drawing.Point(93, 399);
            this.btRcerrar.Name = "btRcerrar";
            this.btRcerrar.Size = new System.Drawing.Size(75, 23);
            this.btRcerrar.TabIndex = 2;
            this.btRcerrar.Text = "Cerrar";
            this.btRcerrar.UseVisualStyleBackColor = true;
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 440);
            this.Controls.Add(this.btRcerrar);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.lbResult);
            this.Name = "FormResultados";
            this.Text = "FormResultados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbResult;
        public System.Windows.Forms.ListBox listResult;
        public System.Windows.Forms.Button btRcerrar;
    }
}