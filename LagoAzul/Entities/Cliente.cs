using LagoAzul.Entities.Enums;
using LagoAzul.Entities;
using System.Collections.Generic;

namespace LagoAzul.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public int CPF_CNPJ { get; set; }
        public Endereco Endereco { get; set; }
        public string CEP { get; set; }
        public string? Email { get; set; }
        public string[] Telefones = new string[3];
        public List<Pedido> ListaPedidos = new List<Pedido>();

        public Cliente(string nome, TipoPessoa tipoPessoa, int cPF_CNPJ, Endereco endereco, string cEP, string email, string[] telefones, Pedido pedido)
        {
            Nome = nome;
            TipoPessoa = tipoPessoa;
            CPF_CNPJ = cPF_CNPJ;
            Endereco = endereco;
            CEP = cEP;
            Email = email;
            Telefones = telefones;
        }

        
    }
}
