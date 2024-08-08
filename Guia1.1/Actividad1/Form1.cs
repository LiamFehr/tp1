using Actividad1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cocina cocina;
        private void Crear_Click(object sender, EventArgs e)
        {
            Alacena alacena = new Alacena();

            cocina = new Cocina(alacena);
            Amasador am = new Amasador();

            cocina = new Cocina(am);
        }

        private void Reponer_Click(object sender, EventArgs e)
        {
            Alacena alacena = cocina.alacena;
            alacena.Reponer(50,100);
        }

        private void Tomar_Click(object sender, EventArgs e)
        {
            Alacena ala= cocina.alacena;
            Amasador amasa = cocina.amasador;
            double harina, fruta;
            harina = ala.TomarHarina(Convert.ToDouble(CantHarina.Text));
            fruta = ala.TomarFruta(Convert.ToDouble(CantFrutas.Text));

        }
    }
}
