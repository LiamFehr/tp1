using System;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        Competencia comp = new Competencia();
        private void button1_Click(object sender, EventArgs e)
        {
            FormNombre ingresa = new FormNombre();
            string compe = "";
            if (ingresa.ShowDialog() == DialogResult.OK)
            {
                compe = ingresa.tbNombre.Text;
                comp.AgregarCompetidos(compe);
            }
            ingresa.Dispose();

        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
           FormCargarTiempo tiempo = new FormCargarTiempo();
            int HH = 0,MM = 0, ID = 0;

            tiempo.lbid.Text = "1";

            while (tiempo.ShowDialog() == DialogResult.OK)
            {
                HH = Convert.ToInt32(tiempo.HHtext.Text);
                tiempo.HHtext.Clear();
                MM = Convert.ToInt32(tiempo.MMtext.Text);
                tiempo.MMtext.Clear();
                
                comp.CargarTiempo(ID, HH, MM);

                ID++;
                tiempo.lbid.Text = (ID+1).ToString();
            }
            tiempo.Dispose();
        }

        private void btResultados_Click(object sender, EventArgs e)
        {
            FormResultados result=new FormResultados();
            comp.OrdenarTiempo();
            int TT = 0, HH = 0, MM = 0;
            for(int i = 0; i < comp.cont; i++)
            { 
                TT = comp.Tiempo[i];
                HH = TT / 60;
                MM = TT % 60;
                result.listResult.Items.Add($"{comp.Nombres[i]},{HH}:{MM}");
            }
            result.ShowDialog();
            result.Dispose();
        }
    }
}
