namespace Proyecto1
{
    partial class EditorCodigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorCodigo));
            this.menuStripEditorCodigo = new System.Windows.Forms.MenuStrip();
            this.pantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLaAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorCodigoRichText = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.abrirButton = new System.Windows.Forms.Button();
            this.cerrarButton = new System.Windows.Forms.Button();
            this.borrarButton = new System.Windows.Forms.Button();
            this.crearButton = new System.Windows.Forms.Button();
            this.codigoAbiertoCombo = new System.Windows.Forms.ComboBox();
            this.txtNombreProyecto = new System.Windows.Forms.Label();
            this.exportarButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.salidaErroresRichText = new System.Windows.Forms.RichTextBox();
            this.posicionTextBox = new System.Windows.Forms.TextBox();
            this.nombreProyectoTextBox = new System.Windows.Forms.TextBox();
            this.compilarButton = new System.Windows.Forms.Button();
            this.openProyecto = new System.Windows.Forms.OpenFileDialog();
            this.saveErrorFiles = new System.Windows.Forms.SaveFileDialog();
            this.menuStripEditorCodigo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripEditorCodigo
            // 
            this.menuStripEditorCodigo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripEditorCodigo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStripEditorCodigo.Location = new System.Drawing.Point(0, 0);
            this.menuStripEditorCodigo.Name = "menuStripEditorCodigo";
            this.menuStripEditorCodigo.Size = new System.Drawing.Size(1383, 28);
            this.menuStripEditorCodigo.TabIndex = 0;
            this.menuStripEditorCodigo.Text = "menuStrip1";
            // 
            // pantallaToolStripMenuItem
            // 
            this.pantallaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.volverMenuToolStripMenuItem});
            this.pantallaToolStripMenuItem.Name = "pantallaToolStripMenuItem";
            this.pantallaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.pantallaToolStripMenuItem.Text = "Pantalla";
            this.pantallaToolStripMenuItem.Click += new System.EventHandler(this.pantallaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir proyecto";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // volverMenuToolStripMenuItem
            // 
            this.volverMenuToolStripMenuItem.Name = "volverMenuToolStripMenuItem";
            this.volverMenuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.volverMenuToolStripMenuItem.Text = "Volver al Menu";
            this.volverMenuToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem1_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem1,
            this.cerrarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.archivoToolStripMenuItem.Text = "Proyecto";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem1.Text = "Guardar";
            this.guardarToolStripMenuItem1.Click += new System.EventHandler(this.guardarToolStripMenuItem1_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLaAyudaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verLaAyudaToolStripMenuItem
            // 
            this.verLaAyudaToolStripMenuItem.Name = "verLaAyudaToolStripMenuItem";
            this.verLaAyudaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verLaAyudaToolStripMenuItem.Text = "Ver la ayuda";
            this.verLaAyudaToolStripMenuItem.Click += new System.EventHandler(this.verLaAyudaToolStripMenuItem_Click);
            // 
            // editorCodigoRichText
            // 
            this.editorCodigoRichText.AcceptsTab = true;
            this.editorCodigoRichText.BackColor = System.Drawing.Color.Silver;
            this.editorCodigoRichText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorCodigoRichText.Location = new System.Drawing.Point(24, 77);
            this.editorCodigoRichText.Name = "editorCodigoRichText";
            this.editorCodigoRichText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.editorCodigoRichText.Size = new System.Drawing.Size(1004, 470);
            this.editorCodigoRichText.TabIndex = 1;
            this.editorCodigoRichText.Text = "";
            this.editorCodigoRichText.WordWrap = false;
            this.editorCodigoRichText.CursorChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.editorCodigoRichText.TextChanged += new System.EventHandler(this.editorCodigoRichText_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.abrirButton);
            this.panel1.Controls.Add(this.cerrarButton);
            this.panel1.Controls.Add(this.borrarButton);
            this.panel1.Controls.Add(this.crearButton);
            this.panel1.Controls.Add(this.codigoAbiertoCombo);
            this.panel1.Location = new System.Drawing.Point(1059, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 470);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Archivos Codigo Abiertos";
            // 
            // abrirButton
            // 
            this.abrirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abrirButton.Location = new System.Drawing.Point(92, 373);
            this.abrirButton.Name = "abrirButton";
            this.abrirButton.Size = new System.Drawing.Size(104, 59);
            this.abrirButton.TabIndex = 4;
            this.abrirButton.Text = "Abrir";
            this.abrirButton.UseVisualStyleBackColor = true;
            this.abrirButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // cerrarButton
            // 
            this.cerrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarButton.Location = new System.Drawing.Point(92, 215);
            this.cerrarButton.Name = "cerrarButton";
            this.cerrarButton.Size = new System.Drawing.Size(104, 58);
            this.cerrarButton.TabIndex = 3;
            this.cerrarButton.Text = "Cerrar";
            this.cerrarButton.UseVisualStyleBackColor = true;
            this.cerrarButton.Click += new System.EventHandler(this.cerrarButton_Click);
            // 
            // borrarButton
            // 
            this.borrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarButton.Location = new System.Drawing.Point(92, 290);
            this.borrarButton.Name = "borrarButton";
            this.borrarButton.Size = new System.Drawing.Size(104, 62);
            this.borrarButton.TabIndex = 2;
            this.borrarButton.Text = "Borrar";
            this.borrarButton.UseVisualStyleBackColor = true;
            this.borrarButton.Click += new System.EventHandler(this.borrarButton_Click);
            // 
            // crearButton
            // 
            this.crearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearButton.Location = new System.Drawing.Point(92, 132);
            this.crearButton.Name = "crearButton";
            this.crearButton.Size = new System.Drawing.Size(104, 60);
            this.crearButton.TabIndex = 1;
            this.crearButton.Text = "Crear";
            this.crearButton.UseVisualStyleBackColor = true;
            this.crearButton.Click += new System.EventHandler(this.crearButton_Click);
            // 
            // codigoAbiertoCombo
            // 
            this.codigoAbiertoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codigoAbiertoCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoAbiertoCombo.FormattingEnabled = true;
            this.codigoAbiertoCombo.Location = new System.Drawing.Point(30, 77);
            this.codigoAbiertoCombo.Name = "codigoAbiertoCombo";
            this.codigoAbiertoCombo.Size = new System.Drawing.Size(228, 33);
            this.codigoAbiertoCombo.TabIndex = 0;
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.AutoSize = true;
            this.txtNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProyecto.Location = new System.Drawing.Point(19, 45);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(208, 29);
            this.txtNombreProyecto.TabIndex = 9;
            this.txtNombreProyecto.Text = "Nombre Proyecto:";
            // 
            // exportarButton
            // 
            this.exportarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarButton.Location = new System.Drawing.Point(1131, 714);
            this.exportarButton.Name = "exportarButton";
            this.exportarButton.Size = new System.Drawing.Size(141, 62);
            this.exportarButton.TabIndex = 12;
            this.exportarButton.Text = "Exportar";
            this.exportarButton.UseVisualStyleBackColor = true;
            this.exportarButton.Click += new System.EventHandler(this.exportarButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Posicion:";
            // 
            // salidaErroresRichText
            // 
            this.salidaErroresRichText.BackColor = System.Drawing.Color.Silver;
            this.salidaErroresRichText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salidaErroresRichText.Location = new System.Drawing.Point(24, 618);
            this.salidaErroresRichText.Name = "salidaErroresRichText";
            this.salidaErroresRichText.ReadOnly = true;
            this.salidaErroresRichText.Size = new System.Drawing.Size(1004, 158);
            this.salidaErroresRichText.TabIndex = 14;
            this.salidaErroresRichText.Text = "";
            // 
            // posicionTextBox
            // 
            this.posicionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posicionTextBox.Location = new System.Drawing.Point(182, 561);
            this.posicionTextBox.Name = "posicionTextBox";
            this.posicionTextBox.ReadOnly = true;
            this.posicionTextBox.Size = new System.Drawing.Size(282, 30);
            this.posicionTextBox.TabIndex = 15;
            this.posicionTextBox.Text = "Fila:1 Columna:1";
            this.posicionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombreProyectoTextBox
            // 
            this.nombreProyectoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreProyectoTextBox.Location = new System.Drawing.Point(281, 45);
            this.nombreProyectoTextBox.Name = "nombreProyectoTextBox";
            this.nombreProyectoTextBox.ReadOnly = true;
            this.nombreProyectoTextBox.Size = new System.Drawing.Size(610, 30);
            this.nombreProyectoTextBox.TabIndex = 16;
            this.nombreProyectoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compilarButton
            // 
            this.compilarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compilarButton.Location = new System.Drawing.Point(1131, 618);
            this.compilarButton.Name = "compilarButton";
            this.compilarButton.Size = new System.Drawing.Size(141, 62);
            this.compilarButton.TabIndex = 17;
            this.compilarButton.Text = "Compilar";
            this.compilarButton.UseVisualStyleBackColor = true;
            this.compilarButton.Click += new System.EventHandler(this.compilarButton_Click);
            // 
            // openProyecto
            // 
            this.openProyecto.Filter = "Archivos de Proyecto(*.gt)|*.gt";
            // 
            // saveErrorFiles
            // 
            this.saveErrorFiles.Filter = "Archivos de Error(*.gtE)|*.gtE*";
            // 
            // EditorCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 802);
            this.Controls.Add(this.compilarButton);
            this.Controls.Add(this.nombreProyectoTextBox);
            this.Controls.Add(this.posicionTextBox);
            this.Controls.Add(this.salidaErroresRichText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.exportarButton);
            this.Controls.Add(this.txtNombreProyecto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editorCodigoRichText);
            this.Controls.Add(this.menuStripEditorCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripEditorCodigo;
            this.Name = "EditorCodigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Editor Codigo";
            this.Load += new System.EventHandler(this.EditorCodigo_Load);
            this.menuStripEditorCodigo.ResumeLayout(false);
            this.menuStripEditorCodigo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripEditorCodigo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLaAyudaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox editorCodigoRichText;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtNombreProyecto;
        private System.Windows.Forms.Button abrirButton;
        private System.Windows.Forms.Button cerrarButton;
        private System.Windows.Forms.Button borrarButton;
        private System.Windows.Forms.Button crearButton;
        private System.Windows.Forms.ComboBox codigoAbiertoCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button exportarButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox salidaErroresRichText;
        private System.Windows.Forms.TextBox posicionTextBox;
        private System.Windows.Forms.TextBox nombreProyectoTextBox;
        private System.Windows.Forms.Button compilarButton;
        private System.Windows.Forms.ToolStripMenuItem pantallaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverMenuToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openProyecto;
        private System.Windows.Forms.SaveFileDialog saveErrorFiles;
    }
}