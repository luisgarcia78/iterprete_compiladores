using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.calitha.goldparser;

namespace INTERPRETE
{
    public partial class Form1 : Form
    {
        MyParser parser;
        public Form1()
        {
            parser = new MyParser(Application.StartupPath + "\\interprete.cgt");
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsoftware_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void btnejecutar_Click(object sender, EventArgs e)
        {

            MyParser.TablaSimbolo.Clear();
            MyParser.salida = string.Empty;
            MyParser.errores = String.Empty;
            ClearType();
            lstVtabla.Items.Clear();
            parser.Parse(txtsoftware.Text);
            for (int i = 0; i < MyParser.TablaSimbolo.Count; i++)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(MyParser.TablaSimbolo[i].id),0);
                item.SubItems.Add(Convert.ToString(MyParser.TablaSimbolo[i].tipo));

                if (MyParser.TablaSimbolo[i].tipo == "entero")
                    item.SubItems.Add(Convert.ToString(MyParser.enteros[MyParser.TablaSimbolo[i].indice]));
                else if (MyParser.TablaSimbolo[i].tipo == "real")
                    item.SubItems.Add(Convert.ToString(MyParser.real[MyParser.TablaSimbolo[i].indice]));
                else if (MyParser.TablaSimbolo[i].tipo == "cadena")
                    item.SubItems.Add(MyParser.cadena[MyParser.TablaSimbolo[i].indice]);
                else if (MyParser.TablaSimbolo[i].tipo == "caracter")
                    item.SubItems.Add(Convert.ToString(MyParser.caracter[MyParser.TablaSimbolo[i].indice]));
                lstVtabla.Items.Add(item);
            }
            txtsalida.Text = MyParser.salida;
            txterror.Text = MyParser.errores;
        }

       
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsoftware.Text = string.Empty;
            txtsalida.Text = String.Empty;
            lstVtabla.Items.Clear();
            txterror.Text = String.Empty;
        }
        public void ClearType()
        {
            for (int i = 0; i < MyParser.enteros.Length; i++) MyParser.enteros[i] = 0;
            for (int i = 0; i < MyParser.real.Length; i++) MyParser.real[i] = 0.0;
            for (int i = 0; i < MyParser.cadena.Length; i++) MyParser.cadena[i] = "";
            for (int i = 0; i < MyParser.caracter.Length; i++) MyParser.caracter[i] = ' ';
        }

        private void lstVtabla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnleer_Click(object sender, EventArgs e)
        {   //creamos un nuevo objeto 
            StreamReader leer = new StreamReader(@"C:\Users\provi\Desktop\codigo.txt");
            String linea;

            try
            {
                linea = leer.ReadLine();
                while(linea != null)
                {
                    txtsoftware.AppendText(linea + "\r\n");
                    linea = leer.ReadLine();
                }

            }
            catch
            {
                MessageBox.Show("Error al leer el archivo");
            }

        }
    }
}
