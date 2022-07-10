using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace calculadoraDeArea
{
    public class Calculadora
    {
        public void areaTriangulo()
        {
            Console.WriteLine("Digite a base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double triangulo = (baseTriangulo * alturaTriangulo) / 2.0;
            Console.WriteLine($"Altura do triângulo: {baseTriangulo}");
            Console.WriteLine($"Altura do triângulo : {alturaTriangulo}");
            Console.WriteLine("Área do triângulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("");
        }

        public void areaCirculo()
        {
            Console.WriteLine("Digite o raio do círculo: ");
            double raioCirculo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circulo = ((raioCirculo * raioCirculo) * 3.14159);
            Console.WriteLine($"Raio do círculo: {raioCirculo}");
            Console.WriteLine("Área do círculo: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("");
        }

        public void areaQuadrado()
        {
            Console.WriteLine("Digite a altura do quadrado: ");
            double alturaQuadradro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double quadrado = (alturaQuadradro * alturaQuadradro);
            Console.WriteLine($"Altura do quadrado: {alturaQuadradro}");
            Console.WriteLine("Área do quadrado: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("");
        }
        public void areaRetangulo()
        {
            Console.WriteLine("Digite a altura do retângulo: ");
            double alturaRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a largura do retângulo: ");
            double larguraRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double retangulo = (alturaRetangulo * larguraRetangulo);
            Console.WriteLine($"Altura do retângulo: {alturaRetangulo}");
            Console.WriteLine($"Largura do retângulo: {larguraRetangulo}");
            Console.WriteLine("Área do quadrado: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("");

        }

        public void areaTrapezio()
        {
            Console.WriteLine("Digite a base maior do trapézio: ");
            double baseMaior = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a base menor do trapézio: ");
            double baseMenor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (baseMenor > baseMaior)
            {
                Console.WriteLine("A base menor do trapézio não pode ser maior que a base maior do trapézio. Reinicie o programa.");
                Console.WriteLine("");

            }
            else if (baseMenor == baseMaior)
            {
                Console.WriteLine("As bases do trapézio não podem ter tamanhos iguais. Reinicie o programa.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Digite a altura do trapézio: ");
                double alturaTrapezio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double trapezio = (((baseMaior + baseMenor) * alturaTrapezio) / 2);
                Console.WriteLine($"Base maior do trapézio: {baseMaior}");
                Console.WriteLine($"Base menor do trapézio {baseMenor}");
                Console.WriteLine($"Altura do trapézio: {alturaTrapezio}");
                Console.WriteLine("Área do trapézio: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }

        }

        public void areaLosango()
        {
            Console.WriteLine("Digite a diagonal maior do losango: ");
            double diagonalMaior = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a diagonal menor do losango: ");
            double diagonalMenor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (diagonalMenor > diagonalMaior)
            {
                Console.WriteLine("A diagonal menor do losango não pode ser maior que a diagonal maior do losango. Reinicie o programa.");
                Console.WriteLine("");

            }
            else if (diagonalMenor == diagonalMaior)
            {
                Console.WriteLine("As diagonais do losango não podem ter tamanhos iguais. Reinicie o programa.");
                Console.WriteLine("");
            }
            else
            {
                double losango = ((diagonalMaior * diagonalMenor) / 2);
                Console.WriteLine($"Diagonal maior do losango: {diagonalMaior}");
                Console.WriteLine($"Diagonal menor do losango {diagonalMenor}");
                Console.WriteLine("Área do losango: " + losango.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }

        }
    }
}
