using System;

namespace ConsoleApplication1
{
    public class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            Console.WriteLine("# Imposto ICMS #...");
            return orcamento.Valor * 0.1;
        }
    }
}