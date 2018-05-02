using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Informacoes { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto, double impostos,
            IList<ItemDaNota> itens, string informacoes)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            DataEmissao = dataEmissao;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens;
            Informacoes = informacoes;
        }
    }
}