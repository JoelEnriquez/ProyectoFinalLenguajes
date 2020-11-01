namespace Proyecto1.Windows
{
    partial class AbrirBorrarCodigo
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
            this.agregarEliminarButton = new System.Windows.Forms.Button();
            this.codigoComboBox = new System.Windows.Forms.ComboBox();
            this.txtNombreCodi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregarEliminarButton
            // 
            this.agregarEliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarEliminarButton.Location = new System.Drawing.Point(135, 220);
            this.agregarEliminarButton.Name = "agregarEliminarButton";
            this.agregarEliminarButton.Size = new System.Drawing.Size(181, 60);
            this.agregarEliminarButton.TabIndex = 0;
            this.agregarEliminarButton.Text = "button1";
            this.agregarEliminarButton.UseVisualStyleBackColor = true;
            this.agregarEliminarButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // codigoComboBox
            // 
            this.codigoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoComboBox.FormattingEnabled = true;
            this.codigoComboBox.Location = new System.Drawing.Point(110, 127);
            this.codigoComboBox.Name = "codigoComboBox";
            this.codigoComboBox.Size = new System.Drawing.Size(227, 44);
            this.codigoComboBox.TabIndex = 1;
            // 
            // txtNombreCodi
            // 
            this.txtNombreCodi.AutoSize = true;
            this.txtNombreCodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCodi.Location = new System.Drawing.Point(76, 60);
            this.txtNombreCodi.Name = "txtNombreCodi";
            this.txtNombreCodi.Size = new System.Drawing.Size(309, 32);
            this.txtNombreCodi.TabIndex = 2;
            this.txtNombreCodi.Text = "Lista de Codigo Fuente";
            // 
            // AbrirBorrarCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(483, 354);
            this.Controls.Add(this.txtNombreCodi);
            this.Controls.Add(this.codigoComboBox);
            this.Controls.Add(this.agregarEliminarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AbrirBorrarCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbrirBorrarCodigo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarEliminarButton;
        private System.Windows.Forms.ComboBox codigoComboBox;
        private System.Windows.Forms.Label txtNombreCodi;
    }
}