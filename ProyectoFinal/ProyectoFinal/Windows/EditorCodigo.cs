using Microsoft.VisualBasic;
using Proyecto1.Logica;
using Proyecto1.ObjetosCodigo;
using Proyecto1.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Proyecto1
{
    public partial class EditorCodigo : Form
    {
        private Boolean codigoGuardado = true;
        private Proyecto proyecto;
        private String rutaProyecto;
        private PantallaInicio inicio;
        private LeerGuardarProyecto leerGuardar;
        private AbrirBorrarCodigo abrirBorrar;
        private ManejadorCodigo manejador;

        public EditorCodigo(PantallaInicio inicio, Proyecto proyecto, String rutaProyecto, LeerGuardarProyecto leerGuardar)
        {
            this.inicio = inicio;
            this.proyecto = proyecto;
            this.rutaProyecto = rutaProyecto;
            this.leerGuardar = leerGuardar;
            manejador = new ManejadorCodigo(this);
            InitializeComponent();
            setearComponentes(); //Este se da cuando se ejecuta la primera vez la ventana
            agregarEventos();//Se agregan eventos a los componentes
        }

        private void setearComponentes()
        {
            setearNombreProyectoTextBox();
            editorCodigoRichText.ReadOnly = true;
            salidaErroresRichText.ReadOnly = true;
        }

        private void reSetearComponentes()
        {
            setearNombreProyectoTextBox();
            limpiarComponentes();
        }

        private void anularComponentes()
        {
            limpiarComponentes();

            //Anulamos los componentes del proyecto actual
            rutaProyecto = "";
            nombreProyectoTextBox.Text = rutaProyecto;
            proyecto = null;
        }

        private void limpiarComponentes()
        {
            codigoAbiertoCombo.Items.Clear();
            editorCodigoRichText.Text = "";
            editorCodigoRichText.BackColor = Color.Silver;
            salidaErroresRichText.Text = "";
            editorCodigoRichText.ReadOnly = true;
            salidaErroresRichText.ReadOnly = true;
        }

        private void setearNombreProyectoTextBox()
        {
            String[] separadorRuta = rutaProyecto.Split('\\');
            int posicionNombreProyecto = separadorRuta.Length - 1;
            nombreProyectoTextBox.Text = separadorRuta[posicionNombreProyecto];
        }

        private void agregarEventos()
        {
            codigoAbiertoCombo.SelectedIndexChanged += new System.EventHandler(ComboCodigoAbierto_SelectedItemChanged);
            editorCodigoRichText.SelectionChanged += new EventHandler(editorRichTextBox_SelectionChanged);
        }



        private void setearCodigo()
        {
            editorCodigoRichText.ReadOnly = false;
            editorCodigoRichText.BackColor = Color.White;

            String codigo = proyecto.devolverCodigoFuente(codigoAbiertoCombo.Text);
            editorCodigoRichText.Text = codigo;
        }

        public void getPositionCurse()
        {
            int caretPos = editorCodigoRichText.SelectionStart;
        }

        private void EditorCodigo_Load(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void noseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (proyecto != null)
            {
                if (codigoAbiertoCombo.Items.Count < proyecto.getCodigoFuentes().Count)
                {
                    abrirBorrar = new AbrirBorrarCodigo(this, proyecto, "Abrir");
                    abrirBorrar.ShowDialog(this);

                    codigoAbiertoCombo.Items.Add(abrirBorrar.nombreAgregadoEliminado());
                    codigoAbiertoCombo.SelectedItem = abrirBorrar.nombreAgregadoEliminado();
                    setearCodigo();
                }
                else
                {
                    MessageBox.Show("Ya se han abierto todos los archivos de codigo del proyecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay proyecto cargado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!codigoGuardado)
            {
                preguntarGuardarProyecto();
            }

            if (openProyecto.ShowDialog() == DialogResult.OK)
            {
                rutaProyecto = openProyecto.FileName;
                proyecto = leerGuardar.leerProyecto(rutaProyecto);
                reSetearComponentes(); //Se vuelven a pintar los componentes con el archivo que se habra   
                codigoGuardado = true;
            }

        }

        /// <summary>
        /// Sirve para cerrar la ventana antes preguntando si quiere guardar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!codigoGuardado)
            {
                preguntarGuardarProyecto();
            }

            inicio.Visible = true;
            this.Close();
        }

        private void preguntarGuardarProyecto()
        {
            DialogResult result = MessageBox.Show("No se ha guardado el proyecto. ¿Deseas guardarlo?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                codigoGuardado = true;
                leerGuardar.guardarProyecto(rutaProyecto, proyecto);
            }

        }

        /// <summary>
        /// Este metodo sirve para cerrar un proyecto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!codigoGuardado)
            {
                preguntarGuardarProyecto();
            }

            anularComponentes();
            codigoGuardado = true;
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            codigoGuardado = true;
            leerGuardar.guardarProyecto(rutaProyecto, proyecto);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proyecto != null)
            {
                DialogResult result = MessageBox.Show("¿Seguro que desea eliminar el proyecto actual?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    leerGuardar.eliminarProyecto(rutaProyecto);
                    anularComponentes();
                    codigoGuardado = true;
                }
            }
            else
            {
                MessageBox.Show("No hay proyecto para eliminar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void crearButton_Click(object sender, EventArgs e)
        {
            if (proyecto==null)
            {
                MessageBox.Show("No se ha seleccionado ningun proyecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String nombreCodigo = Interaction.InputBox("Ingrese nombre del Codigo Fuente:", "Nombre Codigo Fuente", "").Trim();
                if (nombreCodigo.Equals(""))
                {
                    MessageBox.Show("No se ha escrito ningun nombre para el nombre codigo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (repeticionNombreCodigo(nombreCodigo))
                    {
                        MessageBox.Show("Ya existe dicho nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CodigoFuente codigoFuente = new CodigoFuente(nombreCodigo);
                        proyecto.agregarCodigoFuente(codigoFuente);

                        codigoAbiertoCombo.Items.Add(codigoFuente.getNombreCodigo());
                        codigoAbiertoCombo.SelectedItem = nombreCodigo;
                        codigoGuardado = false;

                        setearCodigo();
                    }
                }
            }           
        }

        /// <summary>
        /// Busca entre el arraylist de proyecto para ver si coincide el nombre y ver si no se repite
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private Boolean repeticionNombreCodigo(String nombre)
        {
            for (int i = 0; i < proyecto.getCodigoFuentes().Count; i++)
            {
                if (((CodigoFuente)proyecto.getCodigoFuentes()[i]).getNombreCodigo().Equals(nombre))
                {
                    return true;
                }
            }
            return false;
        }

        private void pantallaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            if (codigoAbiertoCombo.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos para cerrar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                codigoAbiertoCombo.Items.RemoveAt(codigoAbiertoCombo.SelectedIndex);
                if (codigoAbiertoCombo.Items.Count > 0)
                {
                    codigoAbiertoCombo.SelectedIndex = 0;
                    setearCodigo();
                }
                else
                {
                    codigoAbiertoCombo.Refresh();
                    limpiarComponentes();
                    codigoGuardado = true;
                }
            }
        }

        private void borrarButton_Click(object sender, EventArgs e)
        {
            if (proyecto != null)
            {
                if (proyecto.getCodigoFuentes().Count > 0)
                {
                    abrirBorrar = new AbrirBorrarCodigo(this, proyecto, "Borrar");
                    abrirBorrar.ShowDialog(this);

                    codigoAbiertoCombo.Items.Remove(abrirBorrar.nombreAgregadoEliminado());
                    if (codigoAbiertoCombo.Items.Count > 0)
                    {
                        codigoAbiertoCombo.SelectedIndex = 0;
                        setearCodigo();
                    }
                    else
                    {
                        codigoAbiertoCombo.Refresh();
                        limpiarComponentes();
                        codigoGuardado = true;
                    }
                }
                else
                {
                    MessageBox.Show("No hay archivos codigo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No hay proyecto cargado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        public System.Windows.Forms.ComboBox getComboCodigosAbiertos()
        {
            return codigoAbiertoCombo;
        }


        private void ComboCodigoAbierto_SelectedItemChanged(Object sender, System.EventArgs e)
        {
            setearCodigo();
        }

        private void editorCodigoRichText_TextChanged(object sender, EventArgs e)
        {
            proyecto.setearCodigo(codigoAbiertoCombo.Text, editorCodigoRichText.Text);
            manejador.recibirCodigo(editorCodigoRichText.Text);
            manejador.ejecutarManejador();

        }

        private void editorRichTextBox_SelectionChanged(object sender, System.EventArgs e)
        {

            int inicio = editorCodigoRichText.SelectionStart;
            int fila = editorCodigoRichText.GetLineFromCharIndex(inicio)+1;
            int columna = inicio - editorCodigoRichText.GetFirstCharIndexOfCurrentLine()+1;

            posicionTextBox.Text = "Fila:"+fila+ " Columna:" +columna;
        }


        public System.Windows.Forms.RichTextBox GetRichTextBox()
        {
            return editorCodigoRichText;
        }

        public void setRichTextBox(System.Windows.Forms.RichTextBox richTextBox)
        {
            this.editorCodigoRichText = richTextBox;
        }

        private void compilarButton_Click(object sender, EventArgs e)
        {
            if (editorCodigoRichText.Text.Length>0 && proyecto!=null)
            {
                salidaErroresRichText.Clear();

                if (editorCodigoRichText.Text.Length>0)
                {
                    List<String> tokensInvalidos = manejador.obtenerTokensInvalidos();
                    for (int i = 0; i < tokensInvalidos.Count; i++)
                    {
                        salidaErroresRichText.AppendText(tokensInvalidos[i] + "\n");
                    }
                } 
            }
        }

        private void exportarButton_Click(object sender, EventArgs e)
        {
            if (salidaErroresRichText.Text.Length>0)
            {
                if (saveErrorFiles.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writerError = new StreamWriter(File.Create(saveErrorFiles.FileName+".gtE")))
                    {
                        writerError.WriteLine(salidaErroresRichText.Text);
                    }
                }
            }
        }

        private void verLaAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Crea archivos de codigo y teclea tu codigo a tu antojo para escribir" +
                "el programa que quieras diseñar. Si hay fallos lexicos en tu codigo" +
                "el editor te los hará saber, marcandotelos con un rojo naranjo." +
                "Puedes exportar tus fallos, para aprender de tus errores, y ya no volver a " +
                "hacerlos. El listado de palabras reservadas, se encuentra en el manual" +
                "de usuario. Buena suerte!","Ayuda",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
