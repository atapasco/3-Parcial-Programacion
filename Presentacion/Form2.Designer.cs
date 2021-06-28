
namespace Presentacion
{
    partial class Form2
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
            this.cmbCargueArchivo = new System.Windows.Forms.ComboBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCargueArchivo
            // 
            this.cmbCargueArchivo.FormattingEnabled = true;
            this.cmbCargueArchivo.Location = new System.Drawing.Point(267, 88);
            this.cmbCargueArchivo.Name = "cmbCargueArchivo";
            this.cmbCargueArchivo.Size = new System.Drawing.Size(121, 21);
            this.cmbCargueArchivo.TabIndex = 0;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(421, 85);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(75, 23);
            this.btncargar.TabIndex = 1;
            this.btncargar.Text = "cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.cmbCargueArchivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCargueArchivo;
        private System.Windows.Forms.Button btncargar;
    }
}