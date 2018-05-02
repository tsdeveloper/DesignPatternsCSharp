using System;

namespace ConsoleApplication1
{
    public class Reprovado: EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovação!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovado, não pode ser reprovado agora!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}