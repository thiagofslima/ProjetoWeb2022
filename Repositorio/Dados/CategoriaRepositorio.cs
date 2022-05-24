using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Contexto;
using Repositorio.Entidades;

namespace Repositorio.Dados
{
    public class CategoriaRepositorio : BaseRepositorio<Categoria>
    {
        public CategoriaRepositorio(EmpresaContext contexto) : base(contexto)
        {
        }
    }
}
