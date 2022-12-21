using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Repository;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Interfaces;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Implements
{
    public class CategoriaService : ICategoriaService
    {
        private readonly CategoriaRepository _repository;

        public CategoriaService(CategoriaRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Categoria>> GetAllCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
