using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;

namespace ConsoleApplication1
{
    public class Orcamento
    {
        
        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }
        public Status Status { get; set; }
        public int EstadoAtual { get; set; }
        
            
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }


        public void AplicaDescontoExtra()
        {
            throw new System.NotImplementedException();
        }
    }

    public enum Status
    {
        EM_APROVACAO =1,
        APROVADO =2,
        REPROVADO =3,
        FINALIZADO =4,
        
    }
    
            
}