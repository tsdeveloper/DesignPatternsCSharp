using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;

namespace ConsoleApplication1
{
    public class Orcamento
    {
        
        public double Valor { get;  set; }
        public IList<Item> Itens { get; private set; }
       public EstadoDeUmOrcamento EstadoAtual { get; set; }
        
            
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }


        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
        
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }

   
    
            
}