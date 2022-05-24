using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Contexto;
using Repositorio.Entidades;

namespace Repositorio.Dados
{
    public class FuncionarioRepositorio : BaseRepositorio<Funcionario>
    {
        public FuncionarioRepositorio(EmpresaContext contexto) : base(contexto)
        {
        }
    }
}
