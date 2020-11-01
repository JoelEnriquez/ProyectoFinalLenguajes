using Proyecto1.ObjetosCodigo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class PantallaInicio : Form
    {
        LeerGuardarProyecto leerGuardar = new LeerGuardarProyecto();
        EditorCodigo editor;
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog()==DialogResult.OK)
            {
                String path = saveFile.FileName+".gt"; //Asigna la extension de archivo al proyecto para crear el objeto
                Proyecto proyecto = new Proyecto();
                leerGuardar.guardarProyecto(path, proyecto);

                editor = new EditorCodigo(this, proyecto,path,leerGuardar);
                editor.Show();
                this.Visible = false;
            }
        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                String path = openFile.FileName;
                Proyecto proyecto = leerGuardar.leerProyecto(path);
                editor = new EditorCodigo(this,proyecto,path,leerGuardar);
                editor.Show();
                this.Visible = false;             
            }
            
        }
    }
}