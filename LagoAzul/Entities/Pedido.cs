using System;
using System.Collections.Generic;
using System.Text;

namespace LagoAzul.Entities
{
    class Pedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public Pedido(Produto produto,int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public double GetValorTotalPedido()
        {
            return Produto.Preco * Quantidade;
        }
    }
}
