using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Services.ViewModel
{
    public class EnderecoViewModel
    {
        public int EnderecoID { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
