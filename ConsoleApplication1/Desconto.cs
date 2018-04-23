namespace ConsoleApplication1
{
    public interface Desconto
    {
         Desconto Proximo { get; set; }
         double Desconta(Orcamento orcamento);
    }
}