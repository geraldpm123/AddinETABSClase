namespace AddinETABSClase
{
    partial class frmCom01HerramientasETABS
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
            this.btnNuevoETABS = new System.Windows.Forms.Button();
            this.btnAbrirETABS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevoETABS
            // 
            this.btnNuevoETABS.Location = new System.Drawing.Point(106, 36);
            this.btnNuevoETABS.Name = "btnNuevoETABS";
            this.btnNuevoETABS.Size = new System.Drawing.Size(181, 46);
            this.btnNuevoETABS.TabIndex = 0;
            this.btnNuevoETABS.Text = "Crear un archivo en blanco";
            this.btnNuevoETABS.UseVisualStyleBackColor = true;
            this.btnNuevoETABS.Click += new System.EventHandler(this.btnNuevoETABS_Click);
            // 
            // btnAbrirETABS
            // 
            this.btnAbrirETABS.Location = new System.Drawing.Point(106, 100);
            this.btnAbrirETABS.Name = "btnAbrirETABS";
            this.btnAbrirETABS.Size = new System.Drawing.Size(181, 46);
            this.btnAbrirETABS.TabIndex = 1;
            this.btnAbrirETABS.Text = "Abrir archivo existente";
            this.btnAbrirETABS.UseVisualStyleBackColor = true;
            // 
            // frmCom01HerramientasETABS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 276);
            this.Controls.Add(this.btnAbrirETABS);
            this.Controls.Add(this.btnNuevoETABS);
            this.Name = "frmCom01HerramientasETABS";
            this.Text = "frmCom01HerramientasETABS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoETABS;
        private System.Windows.Forms.Button btnAbrirETABS;
    }
}