using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoRapido.Infra.Data.Entities
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public int EnderecoID  { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
