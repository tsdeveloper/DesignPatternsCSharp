 namespace ConsoleApplication1
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional() : base(){}
        
        protected TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto)
        {
        }

       
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento);

            return MinimaTaxacao(orcamento);
        }

        protected abstract double MinimaTaxacao(Orcamento orcamento);

        protected abstract double MaximaTaxacao(Orcamento orcamento);

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);

    }
}