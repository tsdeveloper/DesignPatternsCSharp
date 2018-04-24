using System;

namespace ConsoleApplication1
{
    public class ICMS : Imposto
    {
        public ICMS() : base(){}
        
        public ICMS(Imposto outroImposto) : base(outroImposto)
        {
        }
        public override double Calcula(Orcamento orcamento)
        {
            Console.WriteLine("# Imposto ICMS #...");
            Console.WriteLine($"# Valor Imposto ICMS : {  orcamento.Valor * 0.1   }...");
            Console.WriteLine($"# Valor Imposto ICMS com Outro Imposto: {  orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento)  }...");
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }

       
    }
}