using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Archivos;
using System.IO;
using System.Threading;


namespace Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CrearObjeto() {
            Persona persona1 = new Persona("Leonardo", "Di Caprio");
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

            saveFileDialog1.Filter = "Text Files | *.txt";

            this.saveFileDialog1.DefaultExt = "txt";

            this.saveFileDialog1.ShowDialog();

            

            StreamWriter sw = new StreamWriter(this.saveFileDialog1.FileName, true);

            sw.Close();
            

        }

        private void leerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            this.openFileDialog1.ShowDialog();
            /*StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\personas.txt");


            while (sr.EndOfStream == false)
            {
                this.textBox1.Text = sr.ReadLine();
            }*/
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
