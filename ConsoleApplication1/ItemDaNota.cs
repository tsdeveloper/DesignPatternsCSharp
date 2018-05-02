namespace ConsoleApplication1
{
    public class ItemDaNota
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public ItemDaNota(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

    }
}