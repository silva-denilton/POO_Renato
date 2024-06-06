using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Renato
{
    internal class Casa : Moradia
    {
        public Casa(int _Numeroquartos, int _NumeroBanheiros)
        {
            NumeroQuartos = _Numeroquartos;
            NumeroBanheiros = _NumeroBanheiros;
        }
        public override double CalcularValorAluguel()
        {
            return (AreaTotal - (AreaTotal * 0.1)) / 24;
        }

    }
}
