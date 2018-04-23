namespace ConsoleApplication1
{
    public class DescontosPorCincoItens : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.06;
            }

            return Proximo.Desconta(orcamento);
        }

    }

}