using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Proyecto1.ObjetosCodigo;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto1
{
    public class LeerGuardarProyecto
    {
        public void guardarProyecto(String path, Proyecto proyecto)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, proyecto);
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido guardar el archivo","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        public Proyecto leerProyecto(String path)
        {          
            try
            {
                using (FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Read))
                {
                    Proyecto proyecto;
                    BinaryFormatter bf = new BinaryFormatter();
                    proyecto = (Proyecto) bf.Deserialize(fs);
                    return proyecto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha encontrado el proyecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        

        public void eliminarProyecto(String path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido elimar el proyecto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
