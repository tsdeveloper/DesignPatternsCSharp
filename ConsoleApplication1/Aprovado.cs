using System;

namespace ConsoleApplication1
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
           orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em  aprovação, não pode ser reprovado agora!");
        }

        public void Finaliza(Orcamento orcamento)
        {
           orcamento.EstadoAtual = new Finalizado();
        }
    }
} 