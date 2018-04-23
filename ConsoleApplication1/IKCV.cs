using System.Linq;

namespace ConsoleApplication1
{
    public class IKCV : TemplateDeImpostoCondicional
    {
       

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
 
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 50 && temItemMaiorQue100ReaisNo(orcamento);
                
        }

        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            return orcamento.Itens.Count(i => i.Valor > 100) > 0;
        }
    }
}