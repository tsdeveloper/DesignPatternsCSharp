using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            
            Console.WriteLine("######## Executando Impostos  - Design Patterns Strategy ########...");
            
            var iss = new ISS();
            var icms = new ICMS();
            var ikcv = new IKCV();
            var icpp = new ICPP();

            var orcamento = new Orcamento(500);

            var calculadorDeImpostos = new CalculadorDeImpostos();
            calculadorDeImpostos.RealizaCalculo(orcamento, icms);
            calculadorDeImpostos.RealizaCalculo(orcamento, iss);
     
        
            
            
            Console.WriteLine("######## Finalizando Impostos ########...\n\n" );

            Console.WriteLine("######## Executando Descontos  - Design Patterns Chains of Responsability ########...");

            var calcularDeDescontos = new CalcularDeDescontos();
            var index = 0;
            do
            {
                index++;
                orcamento.AdicionaItem(new Item($"Item { index }", 100 * index));
                
            } while (orcamento.Itens.Count < 6);

            
            Console.WriteLine($"Desconto Calculado:{ calcularDeDescontos.Calcula(orcamento) }");
            Console.WriteLine("######## Finalizando Descontos ########...");
            
            
            Console.WriteLine("######## Executando Impostos  - Design Patterns Template Method ########...");
            Console.WriteLine("Imposto ICPP Calculado:");
            calculadorDeImpostos.RealizaCalculo(orcamento, icpp);
            Console.WriteLine("Imposto IKCV Calculado:");
            calculadorDeImpostos.RealizaCalculo(orcamento, ikcv);
            
            Console.WriteLine("######## Finalizando Impostos  - Design Patterns Template Method ########...");
        }
    }
}