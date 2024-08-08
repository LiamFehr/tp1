using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    public class Alacena
    {
        public double Harina { get; set; }
        public double Fruta { get; set;}

       public void Reponer(double harina, double Fruta)
        {
            this.Harina += harina;  
            this.Fruta += Fruta;
        }
        public double TomarHarina(double Requerido) 
        { if (Requerido <= Harina) 
            {
              Harina -= Requerido;
              return Requerido;
            } 
        else { double restante= Harina; 
              Harina = 0;
                return restante;
            }

        }
        public double TomarFruta(double Requerido) 
        {
            if (Requerido <= Fruta)
            {
                Fruta -= Requerido;
                return Requerido;
            }
            else
            {
                double restante = Fruta;
                Fruta = 0;
                return restante;
            }
        }
    }
}
