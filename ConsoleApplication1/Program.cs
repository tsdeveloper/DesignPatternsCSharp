using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            
//            Console.WriteLine("######## Executando Impostos  - Design Patterns Strategy ########...");
            
//            var iss = new ISS();
//            var icms = new ICMS();
//            var ikcv = new IKCV();
//            var icpp = new ICPP();

//            var orcamento = new Orcamento(500);
//
//            var calculadorDeImpostos = new CalculadorDeImpostos();
//            calculadorDeImpostos.RealizaCalculo(orcamento, icms);
//            calculadorDeImpostos.RealizaCalculo(orcamento, iss);
//     
//        
//            
//            
//            Console.WriteLine("######## Finalizando Impostos ########...\n\n" );
//
//            Console.WriteLine("######## Executando Descontos  - Design Patterns Chains of Responsability ########...");
//
//            var calcularDeDescontos = new CalcularDeDescontos();
//            var index = 0;
//            do
//            {
//                index++;
//                orcamento.AdicionaItem(new Item($"Item { index }", 100 * index));
//                
//            } while (orcamento.Itens.Count < 6);
//
//            
//            Console.WriteLine($"Desconto Calculado:{ calcularDeDescontos.Calcula(orcamento) }");
//            Console.WriteLine("######## Finalizando Descontos ########...");
//            
////            
//            Console.WriteLine("######## Executando Impostos  - Design Patterns Template Method ########...");
//            Console.WriteLine("Imposto ICPP Calculado:");
//            calculadorDeImpostos.RealizaCalculo(orcamento, icpp);
//            Console.WriteLine("Imposto IKCV Calculado:");
//            calculadorDeImpostos.RealizaCalculo(orcamento, ikcv);
//            
//            Console.WriteLine("######## Finalizando Impostos  - Design Patterns Template Method ########...");
            
//            Console.WriteLine("######## Executando Impostos  - Design Patterns Decorator Method ########...");
//            Console.WriteLine("Imposto ISS com ICMS Calculado:");
//            iss = new ISS();
//            calculadorDeImpostos.RealizaCalculo(orcamento, iss);
//          
//            
//            Console.WriteLine("######## Finalizando Impostos  - Design Patterns Decorator Method ########...");
            
//            Console.WriteLine("######## Executando Impostos  - Design Patterns State ########...");
//            var reforma = new Orcamento(500);
//            
//            Console.WriteLine($"Valor Inicial: { reforma.Valor }");
//            
//            Console.WriteLine("Aplicando desconto de acordo ao Estado do Orçamento");
//            reforma.AplicaDescontoExtra();
//            
//            Console.WriteLine($"Valor do Desconto: { reforma.Valor }");
//            
//            
//            Console.WriteLine("Aplicando Estado no Orçamento");
//            reforma.Aprova();
//
//            Console.WriteLine("Aplicando desconto de acordo ao Estado do Orçamento");
//            reforma.AplicaDescontoExtra();
//            reforma.Aprova();
//            
//            
//            Console.WriteLine($"Valor do Desconto: { reforma.Valor }");
//
//            
//            reforma.Finaliza();
//            reforma.AplicaDescontoExtra();
//            
//            Console.WriteLine("######## Finalizando Impostos  - Design Patterns State ########...");
            
            Console.WriteLine("######## Executando Impostos  - Design Patterns State ########...");
            var criadorDeNotaFiscal = new CriadorDeNotaFiscal();
            criadorDeNotaFiscal.ParaEmpresa("Empresa Nota Fiscal");
            criadorDeNotaFiscal.ComCNPJ("12.123.495/0001-03");
            criadorDeNotaFiscal.ComItem(new ItemDaNota("Teste1", 30));
            criadorDeNotaFiscal.ComItem(new ItemDaNota("Teste2", 40));
            criadorDeNotaFiscal.ComObservacoes("Teste Developer Design Patterns");
            criadorDeNotaFiscal.NaDataAtual();

            var nf = criadorDeNotaFiscal.Constroi();
            Type t = nf.GetType();
            foreach (PropertyInfo p in t.GetProperties())
            {
                if (p.PropertyType.IsGenericType)
                {
   
                    Type genericList = p.PropertyType.GetType();
                    foreach (PropertyInfo g in genericList.GetProperties())
                    {
                        Debug.WriteLine($" Property: {g.Name} Value: {g.GetValue(g)}");
                    }
                }

                Debug.WriteLine($" Property: { p.Name } Value: { p.GetValue(nf) }");
                
                //....
            }
           
//            var itemDaNota = new List<ItemDaNota>();
//
//            var i = 0;
//            itemDaNota.ForEach(inf => itemDaNota.Add(new ItemDaNota($"item { i++ }", inf.Valor * i++)));
//            
//            var nf = new NotaFiscal("Razao","123",DateTime.Now,500,itemDaNota.Sum(inf => inf.Valor + 0.05),itemDaNota,"teste");
        }
    }
}