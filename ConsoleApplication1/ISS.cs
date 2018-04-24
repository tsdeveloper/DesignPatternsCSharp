using System;

namespace ConsoleApplication1
{
    public class ISS : Imposto
    {
        public ISS() : base(){}
        
        public ISS(Imposto outroImposto) : base(outroImposto)
        {
        }
        
        
        public override double Calcula(Orcamento orcamento)
        {
            Console.WriteLine("# Imposto ISS #...");
            Console.WriteLine($"# Vaalor Imposto ISS : {  orcamento.Valor * 0.6   }...");
            Console.WriteLine($"# Vaalor Imposto ISS com Outro Imposto: {  orcamento.Valor * 0.6 + CalculoDoOutroImposto(orcamento)  }...");
            return orcamento.Valor * 0.6 + CalculoDoOutroImposto(orcamento);
        }

       
    }
}