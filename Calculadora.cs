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
        public void areaTrianguloRetangulo()
        {
            Console.WriteLine("Digite a base do triângulo retângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite a altura do triângulo retângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double triangulo = (baseTriangulo * alturaTriangulo) / 2.0;
            Console.WriteLine($"Altura do triângulo retângulo: {baseTriangulo}");
            Console.WriteLine($"Altura do triângulo retângulo: {alturaTriangulo}");
            Console.WriteLine("Área do triângulo retângulo: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
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
                double retangulo = (((baseMaior + baseMenor) * alturaTrapezio) / 2);
                Console.WriteLine($"Base maior do trapézio: {baseMaior}");
                Console.WriteLine($"Base menor do trapézio {baseMenor}");
                Console.WriteLine($"Altura do trapézio: {alturaTrapezio}");
                Console.WriteLine("Área do quadrado: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("");
            }

        }
    }
}
