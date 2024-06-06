using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Renato
{
    internal class Inicio
    {

        public void Cadastrar()
        {
            int opcao;
            List<Moradia> _Moradia = new List<Moradia>();
            do
            {
                Console.WriteLine("Selecione a opção que deseja:");
                Console.WriteLine("(1) para Cadastrar uma moradia:");
                Console.WriteLine("(2) para verificar o valor do aluguel:");
                Console.WriteLine("(3) para verificar o valor da venda:");
                Console.WriteLine("(4) para verificar o valor da venda com correçao");
                Console.WriteLine("(5) para verificar tamanho moradia:");
                Console.WriteLine("(6) para verificar data da aquisição:");
                Console.WriteLine("(7) para verificar endereço:");
                Console.WriteLine("(0) para fechar");
                Console.WriteLine();

                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Escolha uma opcão:");
                    Console.WriteLine("(1) para Cadastrar uma casa:");
                    Console.WriteLine("(2) para Cadastrar uma sitio:");
                    Console.WriteLine("(3) para Cadastrar uma apartamento:");
                    int opcao2 = int.Parse(Console.ReadLine());

                    if (opcao2 == 1)
                    {
                        Console.WriteLine("Cadastre um casa:");
                        Console.WriteLine("Digite o numero de quartos:");
                        int numeroquartos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o numero de banheiros:");
                        int numeroBanheiros = int.Parse(Console.ReadLine());
                        Casa _casa = new Casa(numeroquartos, numeroBanheiros);
                        Console.WriteLine("Digite a área construída:");
                        _casa.AreaConstruida = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a área total:");
                        _casa.AreaTotal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a data da aquisição:");
                        _casa.DataAquisicao = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor bruto:");
                        _casa.ValorBruto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o endereço:");
                        _casa.Endereço = Console.ReadLine();
                        _Moradia.Add(_casa);
                    }
                    else if (opcao2 == 2)
                    {
                        Console.WriteLine("Cadastre um sitio:");
                        Sitio _sitio = new Sitio();
                        Console.WriteLine("Digite o numero de quartos:");
                        _sitio.NumeroQuartos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o numero de banheiros:");
                        _sitio.NumeroBanheiros = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a área construída:");
                        _sitio.AreaConstruida = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a área total:");
                        _sitio.AreaTotal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a data da aquisição:");
                        _sitio.DataAquisicao = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor bruto:");
                        _sitio.ValorBruto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o endereço:");
                        _sitio.Endereço = Console.ReadLine();
                        _Moradia.Add(_sitio);
                    }
                    else if (opcao2 == 3)
                    {
                        Console.WriteLine("Cadastre um sitio:");
                        Apartamento _apar = new Apartamento();
                        Console.WriteLine("Digite o numero de quartos:");
                        _apar.NumeroQuartos = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o numero de banheiros:");
                        _apar.NumeroBanheiros = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a área construída:");
                        _apar.AreaConstruida = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a área total:");
                        _apar.AreaTotal = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a data da aquisição:");
                        _apar.DataAquisicao = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor bruto:");
                        _apar.ValorBruto = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o endereço:");
                        _apar.Endereço = Console.ReadLine();
                        _Moradia.Add(_apar);
                    }
                    Console.WriteLine();

                }

                else if (opcao == 2)
                {
                    foreach (var lista in _Moradia)
                    {
                        Console.WriteLine(lista.CalcularValorAluguel());
                    }
                }
                else if(opcao == 3)
                {
                    foreach (var lista in _Moradia)
                    {
                        Console.WriteLine(lista.CalcularValorVenda());
                    }
                }
                else if (opcao == 4)
                {
                    foreach (var lista in _Moradia)
                    {
                        Console.WriteLine("Digite o valor da correção");
                        double correcao = double.Parse(Console.ReadLine());
                        Console.WriteLine(lista.CalcularValorVenda(correcao).ToString("F2"));
                    }
                }
                else if (opcao == 5)
                {
                    foreach (var lista in _Moradia)
                    {
                        Console.WriteLine(lista.VerificarTamanhoMoradia());
                    }
                }
                else if (opcao == 6)
                {
                    foreach (var lista in _Moradia)
                    {  
                        Console.WriteLine(lista.Endereço);
                    }
                }
                else if (opcao == 7)
                {
                    foreach (var lista in _Moradia)
                    {
                        Console.WriteLine(lista.DataAquisicao);
                    }
                }
                Console.WriteLine();
            }
            while (opcao != 0);
        }
    }
}
