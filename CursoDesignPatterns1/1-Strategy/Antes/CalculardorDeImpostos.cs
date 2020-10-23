using System;

namespace CursoDesignPatterns1._1_Strategy.Antes
{
    public class CalculardorDeImpostos
    {
        public void RealizarCalculo(Orcamento orcamento, string imposto)
        {
            if("ICMS".Equals(imposto))
            {
                double icms = orcamento.Valor * 0.1;
                Console.WriteLine(icms);
            }

            if("ISS".Equals(imposto))
            {
                double iss = orcamento.Valor * 0.06;
                Console.WriteLine(iss);
            }
        }
    }
}
