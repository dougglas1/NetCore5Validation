using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5Validation.Entidade
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public Status Status { get; set; }
    }

    public enum Status
    {
        Ativo = 1,
        Inativo = 2
    }
}
