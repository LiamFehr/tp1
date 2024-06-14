using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Guia12._1_parte3.Models
{
    internal class Controlador
    {
        const int cantgen = 50;

        public int[] identis = new int[cantgen];
        public string[] origenes = new string[cantgen];
        public double[] pesos = new double[cantgen];
        public int cont = 0;
        //
        public int[] idsbusqueda = new int[cantgen];
        public string[] origenbusqueda = new string[cantgen];
        public double[] pesobusqueda = new double[cantgen];
        public int contbusqueda = 0;

        public void AgregarContenedor(int identi, string origen, double peso)
        {
            identis[cont] = identi;
            origenes[cont] = origen;
            pesos[cont] = peso;
            cont++;
        }

        public void BuscarPorOrigen(string nombre)
        {
            for (int n = 0; n < cont; n++)
            {
                if (origenes[n] == nombre)
                {
                    idsbusqueda[contbusqueda] = identis[n];
                    origenbusqueda[contbusqueda] = origenes[n];
                    pesobusqueda[contbusqueda] = pesos[n];
                    contbusqueda++;
                }
            }
        }
    }
}
