using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public DateTime dataCadastro { get; set; }
        public int qtde { get; set; }
        public int idCategoria { get; set; }
        public virtual Categoria categoria { get; set; }
    }
}
