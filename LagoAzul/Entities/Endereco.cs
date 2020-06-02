using System;
using System.Collections.Generic;
using System.Text;

namespace LagoAzul.Entities
{
    class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
