using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Orcamento
    {
        
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }
        
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

       

    }
    
            
}