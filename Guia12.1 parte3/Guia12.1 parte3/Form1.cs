
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guia12._1_parte3.Models;

namespace Guia12._1_parte3
{
    public partial class Form1 : Form
    {
        Controlador contr = new Controlador();
        public Form1()
        {
            InitializeComponent();

            contr.AgregarContenedor(1, "Argentina", 324);
            contr.AgregarContenedor(2, "Argentina", 223);
            contr.AgregarContenedor(3, "España", 23);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Datos_del_contenedor contenedor = new Datos_del_contenedor();
            if (contenedor.ShowDialog() == DialogResult.OK)
            {
                int identi = Convert.ToInt32(contenedor.updanwid.Value);
                string origen = contenedor.cbOrigenPais.Text;
                double peso = Convert.ToDouble(contenedor.updawnpeso.Value);

                contr.AgregarContenedor(identi, origen, peso);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string origenPais = textBox1.Text;

            contr.BuscarPorOrigen(origenPais);

            FormVer ver = new FormVer();

            for (int n = 0; n < contr.contbusqueda; n++)
            {
                int id = contr.idsbusqueda[n];
                string origen = contr.origenbusqueda[n];
                double peso = contr.pesobusqueda[n];

                ver.listBox1.Items.Add($"{id} - {origen} - {peso}");
            }

            ver.ShowDialog() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
    

            FormVer ver = new FormVer();

            for (int n = 0; n < contr.cont; n++)
            {
                int id = contr.identis[n];
                string origen = contr.origenes[n];
                double peso = contr.pesos[n];

                ver.listBox1.Items.Add($"{id} - {origen} - {peso}");
            }

            ver.ShowDialog();
        }
    }
}
