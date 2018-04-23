namespace ConsoleApplication1
{
    public class CalcularDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
          
            var d1 = new DescontosPorCincoItens();
            var d2 = new DescontoPorMaisDeQuinhetosReais();
            var d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            return d1.Desconta(orcamento);
        }
    }
}