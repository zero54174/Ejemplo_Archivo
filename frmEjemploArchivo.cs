using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Archivo
{
    public partial class frmEjemploArchivo : Form
    {
        public frmEjemploArchivo()
        {
            InitializeComponent();
        }
        //se invoca el usuario oprime una tecla
        private void txtEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            //determina si el usuario oprimio la tecla enter

            if (e.KeyCode == Keys.Enter)
            {
                string nombreArchgivo; //nombre del archivo
                //obtiene el archivo o directorio especificado por el usuario

                nombreArchgivo = txtEntrada.Text;

                //determinar si nombreArchio si es un archivo
                if(File.Exists(nombreArchgivo))
                {
                    //obtiene la fecha de creacion,
                    //su fecha de modificacion, etc.
                    txtSalida.Text = obtenerInformacion(nombreArchgivo);
                    try
                    {

                        //obtiene lector y contenido del archivo
                        StreamReader sr = new StreamReader(nombreArchgivo);
                        txtSalida.Text += sr.ReadToEnd();

                    }
                    //maneja excepcion si streamreader no esta disponible
                    catch (IOException)
                    {
                        MessageBox.Show("error al leer el archivo", "error de archivo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //determinamos si nombreArchivo es un directorio
                else if(Directory.Exists(nombreArchgivo))
                {
                    string[] listaDirectorio;//arreglo para los directorios

                    //obtiene la fecha de creacion,
                    //su fecha de modificacion, etc.
                    txtSalida.Text = obtenerInformacion(nombreArchgivo);

                    //obtiene la lista de archivos/directorios especificado
                    listaDirectorio = Directory.GetDirectories(nombreArchgivo);

                    txtSalida.Text += "\r\n\r\nContenido del directorio:\r\n";

                    //imprime en pantalla contenido de listaDirctorio
                    for(int i = 0; i < listaDirectorio.Length; i++)
                    {
                        txtSalida.Text += listaDirectorio[i]+"\r\n";
                    }
                }
                else
                {
                    //notifica al usuario que no existe el directorio o archivo
                    MessageBox.Show(txtEntrada.Text+ "no existe","error de archivo",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

        }
        //obtiene informacion del archivo o directorio
        private string obtenerInformacion(string nombreArchgivo)
        {
            string informacion;
            //imprime mensaje indicando que existe el archivo o directorio
            informacion = nombreArchgivo + "existe \r\n\r\n";

            //imprime en pantalla la fecha y hora de creacion del archivo

            informacion += "creacion: " +
                File.GetCreationTime(nombreArchgivo) + "\r\n";
            //imprime en pantalla la fecha de la ultima modificacion del archivo

            informacion += "ultima modificacion: " +
                File.GetLastWriteTime(nombreArchgivo) + "\r\n";
            //imprime en pantalla la fecha y hora del ultimo acceso al archivo

            informacion += "ultimo acceso: " +
                File.GetLastAccessTime(nombreArchgivo) + "\r\n" + "\r\n";


            return informacion;
        }
    }
}
