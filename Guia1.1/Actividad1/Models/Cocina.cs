using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Models
{
    internal class Cocina
    {
        public Alacena alacena;
        public Cocina(Alacena alacena)
        {
            this.alacena = alacena;
        }
        public Amasador amasador;
        public Cocina(Amasador amasador)
        {
            this.amasador = amasador;
        }
}
