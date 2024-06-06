using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Renato
{
    internal class Sitio : Moradia
    {
        public override double CalcularValorAluguel()
        {
            return (AreaTotal - (AreaTotal * 0.15)) / 24;
        }
    }
}
