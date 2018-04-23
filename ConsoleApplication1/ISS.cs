using System;

namespace ConsoleApplication1
{
    public class ISS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            Console.WriteLine("# Imposto ISS #...");
            return orcamento.Valor * 0.6;
        }
    }
}