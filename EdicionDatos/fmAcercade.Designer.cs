namespace elFormulario
{
    partial class fmAcercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAcercade));
            this.pbGrafico = new System.Windows.Forms.PictureBox();
            this.laAutor = new System.Windows.Forms.Label();
            this.laProyecto = new System.Windows.Forms.Label();
            this.laVersion = new System.Windows.Forms.Label();
            this.laFecha = new System.Windows.Forms.Label();
            this.laDescripcionL1 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGrafico
            // 
            this.pbGrafico.Image = global::EdicionDatos.Properties.Resources.alumno_pensante;
            this.pbGrafico.Location = new System.Drawing.Point(7, 9);
            this.pbGrafico.Name = "pbGrafico";
            this.pbGrafico.Size = new System.Drawing.Size(250, 250);
            this.pbGrafico.TabIndex = 0;
            this.pbGrafico.TabStop = false;
            // 
            // laAutor
            // 
            this.laAutor.AutoSize = true;
            this.laAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laAutor.Location = new System.Drawing.Point(281, 30);
            this.laAutor.Name = "laAutor";
            this.laAutor.Size = new System.Drawing.Size(217, 20);
            this.laAutor.TabIndex = 1;
            this.laAutor.Text = "Autor: Mariano Murcia Ortuño";
            // 
            // laProyecto
            // 
            this.laProyecto.AutoSize = true;
            this.laProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laProyecto.Location = new System.Drawing.Point(281, 64);
            this.laProyecto.Name = "laProyecto";
            this.laProyecto.Size = new System.Drawing.Size(174, 20);
            this.laProyecto.TabIndex = 2;
            this.laProyecto.Text = "Proyecto: EdicionDatos";
            // 
            // laVersion
            // 
            this.laVersion.AutoSize = true;
            this.laVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laVersion.Location = new System.Drawing.Point(281, 101);
            this.laVersion.Name = "laVersion";
            this.laVersion.Size = new System.Drawing.Size(76, 20);
            this.laVersion.TabIndex = 3;
            this.laVersion.Text = "Versión 1";
            // 
            // laFecha
            // 
            this.laFecha.AutoSize = true;
            this.laFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laFecha.Location = new System.Drawing.Point(281, 135);
            this.laFecha.Name = "laFecha";
            this.laFecha.Size = new System.Drawing.Size(178, 20);
            this.laFecha.TabIndex = 4;
            this.laFecha.Text = "Fecha: octubre de 2023";
            // 
            // laDescripcionL1
            // 
            this.laDescripcionL1.AutoSize = true;
            this.laDescripcionL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDescripcionL1.Location = new System.Drawing.Point(16, 277);
            this.laDescripcionL1.Name = "laDescripcionL1";
            this.laDescripcionL1.Size = new System.Drawing.Size(505, 40);
            this.laDescripcionL1.TabIndex = 5;
            this.laDescripcionL1.Text = "Proyecto para practicar distintos controles, como botones, label, panel,\r\ngroupbo" +
    "x en el formulario. Sus propiedades y eventos.";
            // 
            // btAceptar
            // 
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(404, 320);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(117, 32);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // fmAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 361);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.laDescripcionL1);
            this.Controls.Add(this.laFecha);
            this.Controls.Add(this.laVersion);
            this.Controls.Add(this.laProyecto);
            this.Controls.Add(this.laAutor);
            this.Controls.Add(this.pbGrafico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmAcercade";
            this.Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGrafico;
        private System.Windows.Forms.Label laAutor;
        private System.Windows.Forms.Label laProyecto;
        private System.Windows.Forms.Label laVersion;
        private System.Windows.Forms.Label laFecha;
        private System.Windows.Forms.Label laDescripcionL1;
        private System.Windows.Forms.Button btAceptar;
    }
}