using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class CriadorDeNotaFiscal
    {
      

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataAtual { get; set; }
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj,DataAtual, ValorTotal, Impostos, todosItens, Observacoes);
        }
        
        public void ParaEmpresa(string razaSocial)
        {
            RazaoSocial = razaSocial;
        }
        
        public void ComObservacoes(string observacoes)
        {
            Observacoes = observacoes ;
        }
        
        public void NaDataAtual()
        {
            DataAtual = DateTime.Now;
        }



        public void ComCNPJ(string cnpj)
        {
            cnpj = cnpj ;
        }

        public void ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;

            Impostos += item.Valor * 0.05;
        }
    }
}