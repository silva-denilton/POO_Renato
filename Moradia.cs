using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Renato
{
    public abstract class Moradia
    {
        public double AreaConstruida;
        public double AreaTotal;
        public DateTime DataAquisicao;
        public int NumeroQuartos;
        public int NumeroBanheiros;
        public double ValorBruto;
        public string Endereço;

        public abstract double CalcularValorAluguel();

        public double CalcularValorVenda()
        {
            return ValorBruto + (ValorBruto * (20 / 100));
        }
        public double CalcularValorVenda(double ValorCorrecao)
        {
            double Correcao = (ValorCorrecao / 100) * ValorBruto;
            return Correcao + ValorBruto;
        }
        public string VerificarTamanhoMoradia()
        {
            var pequena = (AreaTotal * 30 ) / 100;
            var media = (AreaConstruida * 60) / 100;
            var grande = (AreaConstruida * 90 )/ 100;
            
            if (AreaConstruida < pequena)
            {
                return "PEQUENA";
            }
            else if (AreaConstruida < media || AreaConstruida > pequena)
            {
                return "MEDIA";
            }
            else if (AreaConstruida < grande || AreaConstruida > media)
            {
                return "GRANDE";
            }
            else
            {
                return "GIGANTE";
            }
        }
    }
}
