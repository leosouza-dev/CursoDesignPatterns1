using System;

namespace CursoDesignPatterns1._1_Strategy.Depois
{
    public class CalculardorDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, IImposto imposto)
        {
            var valor = imposto.Calcular(orcamento);
            Console.WriteLine(valor);
        }
    }
}
