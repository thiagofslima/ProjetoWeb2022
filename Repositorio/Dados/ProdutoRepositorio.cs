using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Contexto;
using Repositorio.Entidades;

namespace Repositorio.Dados
{
    internal class ProdutoRepositorio : BaseRepositorio<Produto>
    {
        public ProdutoRepositorio(EmpresaContext contexto) : base(contexto)
        {
        }
    }
}
