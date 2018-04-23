namespace ConsoleApplication1
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public double Calcula(Orcamento orcamento)
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