namespace ConsoleApplication1
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP() : base(){}

        public ICPP(Imposto outroImposto) : base(outroImposto)
        {
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;

        }
    }
}