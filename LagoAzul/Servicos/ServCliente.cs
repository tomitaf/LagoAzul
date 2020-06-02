using System;
using System.Collections.Generic;
using System.Text;
using LagoAzul.Entities;

namespace LagoAzul.Servicos
{
    class ServCliente
    {
        public Cliente Cliente { get; set; }

        public ServCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void GetInfoCadastrais()
        {
            // Código que implementa a impressão de dados cadastrais
        }

        public void GerarNota()
        {
            // Código que implementa a geração da nota fiscal
        }
    }
}
