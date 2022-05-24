using System.Collections.Generic;
using Repositorio.Dados;
using Repositorio.Entidades;
using Repositorio.Contexto;

namespace ProjetoWeb2022.Models
{
    public class CategoriaModel
    {
        public int id { get; set; }
        public string descricao { get; set; }

        //Métodos

        public List<CategoriaModel> listar()
        {
            var listaCategoriaModel = new List<CategoriaModel>();

            using (EmpresaContext contexto = new EmpresaContext())
            {
                var repositorio = new CategoriaRepositorio(contexto);
                List<Categoria> lista = repositorio.ListarTodos();
                //Percorrer a lista para preencher a listaCategoriaModel
                foreach (var item in lista)
                {
                    listaCategoriaModel.Add(new CategoriaModel()
                    {
                        descricao = item.descricao,
                        id = item.id
                    });
                }
            }
            return listaCategoriaModel;
        }
    }
}
