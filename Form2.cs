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
    public partial class Form2 : Form
    {
        List<Registro> ListaR = new List<Registro>();
        string Linea = "";
        string path2 = @"C:\Users\teodo\source\repos\Recuperacion\Recuperacion\bin\Debug\MyTest.txt";
        string nombre1="";
        string apellido1="";
        string pais1="";
        string edad1="";
        public Form2()
        {
            InitializeComponent();

            Leer();
        }

        private void RecuperarBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        void Leer()
        {
            StreamReader lector;
            lector = File.OpenText(@"C:\Users\teodo\source\repos\Recuperacion\Recuperacion\bin\Debug\MyTest.txt");
            
            do
            {
                Linea = lector.ReadLine();
                if (Linea != "--")
                {
                    nombre1 = Linea;
                    RecuperarBox.Text+= Linea+ "\r\n";
                    Linea = lector.ReadLine();
                    apellido1 = Linea;
                    RecuperarBox.Text += Linea + "\r\n";
                    Linea = lector.ReadLine();
                    edad1 = Linea;
                    RecuperarBox.Text += Linea + "\r\n";
                    Linea = lector.ReadLine();
                    pais1 = Linea;
                    RecuperarBox.Text += Linea + "\r\n";
                    Registro reg = new Registro(nombre1, apellido1, Convert.ToInt16(edad1), pais1);
                    ListaR.Add(reg);
                }
            } while ((Linea != "--"));
        }
    }
}
