using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Competencia
    {
        const int cant = 100;
        public int cont = 0;
        public  string[] Nombres = new string[cant];
        public  int[] Tiempo = new int[cant];

        public  void AgregarCompetidos(string nombre)
        {
            Nombres[cont++] = nombre;
        }
        public  void CargarTiempo(int numc, int HH, int mm)
        {
          
            int TT = HH * 60 + mm;
            Tiempo[numc] = TT;
        }
        public  void OrdenarTiempo()
        {
            BurbujaTiempo();
        }
        public  void BurbujaTiempo()
        {
            int i = 0, j = 0, aux = 0;
            string aux3;
            for (i = 0; i < cont - 1; i++)
            {
                for (j = i + 1; j < cont; j++)
                {
                    if (Tiempo[i] > Tiempo[j])
                    {
                        aux = Tiempo[i];
                        Tiempo[i] = Tiempo[j];
                        Tiempo[j] = aux;

                        aux3 = Nombres[i];
                        Nombres[i] = Nombres[j];
                        Nombres[j] = aux3;
                    }
                }
            }
        }
       
    }
}
