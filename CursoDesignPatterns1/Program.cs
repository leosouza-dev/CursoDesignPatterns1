using System;
using CursoDesignPatterns1._1_Strategy.Depois;

namespace CursoDesignPatterns1
{
    class Program
    {
        static void Main(string[] args)
        {
            // testando implementação do strategy
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            var orcamento = new Orcamento(1000);

            var calculadorDeImpostos = new CalculardorDeImpostos();
            calculadorDeImpostos.RealizarCalculo(orcamento, iss);
            calculadorDeImpostos.RealizarCalculo(orcamento, icms);
        }
    }
}
