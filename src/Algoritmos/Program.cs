using System;
using System.Collections.Generic;

namespace Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inteiros = new List<int>() { 30, 4, 10, -2, 3, 6, 8 };

            var calcula = new Calcula();
            var maior = calcula.VerificaMaiorNumero(inteiros);
            var menor = calcula.VerificaMenorNumero(inteiros);

            Console.WriteLine($@"O maior numero é: {maior}");
            Console.WriteLine($@"O menor numero é: {menor}");

            var juntos = calcula.VerificaMaiorNumeroMelhor(inteiros);

            Console.WriteLine($@"{juntos}");
        }
    }
}
