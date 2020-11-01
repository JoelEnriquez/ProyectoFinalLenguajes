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

namespace Proyecto1.Windows
{
    public partial class AbrirBorrarCodigo : Form
    {
        private Proyecto proyecto;
        private String funcionButton;
        private EditorCodigo editor;
        private String[] nombreProyectos;
        String nombreModificado = "";

        public AbrirBorrarCodigo(EditorCodigo editor, Proyecto proyecto, String funcionButton)
        {
            this.proyecto = proyecto;
            this.funcionButton = funcionButton;
            this.editor = editor;
            InitializeComponent();
            pintarComponentes();
        }

        private void pintarComponentes()
        {
            if (funcionButton.Equals("Borrar"))
            {
                agregarEliminarButton.Text = funcionButton;
            }
            else
            {
                agregarEliminarButton.Text = funcionButton;
            }

            agregarNombreCodigosCombo();
        }

        private void agregarNombreCodigosCombo()
        {
            nombreProyectos = new String[proyecto.getCodigoFuentes().Count];

            for (int i = 0; i < nombreProyectos.Length; i++)
            {
                CodigoFuente codigo = (CodigoFuente)proyecto.getCodigoFuentes()[i];
                nombreProyectos[i] = codigo.getNombreCodigo();
            }

            codigoComboBox.Items.AddRange(nombreProyectos);
            codigoComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (funcionButton.Equals("Borrar"))
            {
                nombreModificado = codigoComboBox.Text;

                for (int i = 0; i < proyecto.getCodigoFuentes().Count; i++)
                {
                    if (((CodigoFuente)proyecto.getCodigoFuentes()[i]).getNombreCodigo().Equals(nombreModificado))
                    {
                        proyecto.getCodigoFuentes().RemoveAt(i);
                    }
                }
                this.Close();
            }
            else
            {
                nombreModificado = codigoComboBox.Text;
                if (editor.getComboCodigosAbiertos().Items.Contains(nombreModificado))
                {
                    MessageBox.Show("Ya se ha abierto el archivo de codigo","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    this.Close();
                }
            }
        }

        public String nombreAgregadoEliminado()
        {
            return nombreModificado;
        }
    }
}
