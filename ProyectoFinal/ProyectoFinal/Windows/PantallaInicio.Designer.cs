namespace Proyecto1
{
    partial class PantallaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            this.abrirButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.crearButton = new System.Windows.Forms.Button();
            this.txtINNOVATION_IDE = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // abrirButton
            // 
            this.abrirButton.BackColor = System.Drawing.Color.Transparent;
            this.abrirButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.abrirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirButton.Image = global::Proyecto1.Properties.Resources.importar;
            this.abrirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.abrirButton.Location = new System.Drawing.Point(369, 198);
            this.abrirButton.Name = "abrirButton";
            this.abrirButton.Size = new System.Drawing.Size(250, 173);
            this.abrirButton.TabIndex = 3;
            this.abrirButton.Text = "Abrir";
            this.abrirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abrirButton.UseVisualStyleBackColor = false;
            this.abrirButton.Click += new System.EventHandler(this.abrirButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Image = global::Proyecto1.Properties.Resources.cerrar__1_;
            this.closeButton.Location = new System.Drawing.Point(595, 410);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(90, 90);
            this.closeButton.TabIndex = 2;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // crearButton
            // 
            this.crearButton.BackColor = System.Drawing.Color.Transparent;
            this.crearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearButton.Image = global::Proyecto1.Properties.Resources.crear;
            this.crearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.crearButton.Location = new System.Drawing.Point(56, 198);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(250, 173);
            this.crearButton.TabIndex = 0;
            this.crearButton.Text = "Crear";
            this.crearButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.crearButton.UseVisualStyleBackColor = false;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click);
            // 
            // txtINNOVATION_IDE
            // 
            this.txtINNOVATION_IDE.AutoSize = true;
            this.txtINNOVATION_IDE.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINNOVATION_IDE.ForeColor = System.Drawing.Color.Black;
            this.txtINNOVATION_IDE.Location = new System.Drawing.Point(142, 87);
            this.txtINNOVATION_IDE.Name = "txtINNOVATION_IDE";
            this.txtINNOVATION_IDE.Size = new System.Drawing.Size(390, 55);
            this.txtINNOVATION_IDE.TabIndex = 4;
            this.txtINNOVATION_IDE.Text = "INNOVATION IDE";
            // 
            // openFile
            // 
            this.openFile.Filter = "Archivos de Proyecto(*.gt)|*.gt";
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Archivos de Proyecto(*.gt)|*.gt*";
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(692, 503);
            this.Controls.Add(this.txtINNOVATION_IDE);
            this.Controls.Add(this.abrirButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.crearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button abrirButton;
        private System.Windows.Forms.Label txtINNOVATION_IDE;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

