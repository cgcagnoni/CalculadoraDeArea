using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraDeArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de área" + Environment.NewLine);
            Console.WriteLine("Indique o número da opção da forma geométrica correspondente para cálculo de área:");
            Console.WriteLine("1- Círculo");
            Console.WriteLine("2- Losango");
            Console.WriteLine("3- Quadrado");
            Console.WriteLine("4- Retângulo");
            Console.WriteLine("5- Trapézio");
            Console.WriteLine("6- Triângulo");
            Console.WriteLine("7- Sair" + Environment.NewLine);

            int opcaoUsuario = int.Parse(Console.ReadLine());

            switch (opcaoUsuario)
            {
                case 1:
                    Calculadora circulo = new Calculadora();
                    circulo.areaCirculo();
                    break;
                case 2:
                    Calculadora losango = new Calculadora();
                    losango.areaLosango();
                    break;
                case 3:
                    Calculadora quadrado = new Calculadora();
                    quadrado.areaQuadrado();
                    break;
                case 4:
                    Calculadora retangulo = new Calculadora();
                    retangulo.areaRetangulo();
                    break;
                case 5:
                    Calculadora trapezio = new Calculadora();
                    trapezio.areaTrapezio();
                    break;
                case 6:
                    Calculadora trianguloRet = new Calculadora();
                    trianguloRet.areaTriangulo();
                    break;
                case 7:
                    Console.WriteLine("Encerrando o sistena..." + Environment.NewLine);
                    break;
                default:
                    Console.WriteLine("Opção inválida, encerrando o sistena..." + Environment.NewLine);
                    break;
            }
        }
    }
}
