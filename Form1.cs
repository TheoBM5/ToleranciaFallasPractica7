using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Recuperacion
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\teodo\source\repos\Recuperacion\Recuperacion\bin\Debug\MyTest.txt";
        string Linea = "";
        List<Registro> myLote = new List<Registro>();
        int num=0;
        bool bandera=false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(bandera!=true)
            {
                num = Int32.Parse(NumBox.Text);
                Contador.Text = num.ToString();
                bandera = true;
            }
            
            if (num != 0)
            {
                if (File.Exists(path))
                {
                    File.AppendAllText(path, TxtNombre.Text.ToString() + "\n");
                    File.AppendAllText(path, TxtApellidos.Text.ToString() + "\n");
                    File.AppendAllText(path, TxtEdad.Text.ToString() + "\n");
                    File.AppendAllText(path, TxtPais.Text.ToString() + "\n");
                }

                else
                {
                    MessageBox.Show("Error");
                }
                Limpiar();
                Contador.Text = (num-1).ToString();
                num--;
            }
            else
            {
                File.AppendAllText(path, "--" + "\n");
                MessageBox.Show("LLeno");
            }
        }

        void Limpiar()
        {
            TxtNombre.Clear();
            TxtApellidos.Clear();
            TxtEdad.Clear();
            TxtPais.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}



