using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Repository
{
    public class CategoriaRepository
    {
        private readonly ContextoDatabase _context;

        public CategoriaRepository(ContextoDatabase context)
        {
            _context= context;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
