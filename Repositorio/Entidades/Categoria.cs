using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Categoria
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public virtual ICollection<Produto> produtos { get; set; }

        public Categoria()
        {
            this.produtos = new HashSet<Produto>();
        }
    }
}
