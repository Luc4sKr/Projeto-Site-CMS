using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Repository;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Interfaces;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Implements
{
	public class ConteudoService : IConteudoService
	{
		private readonly ConteudoRepository _repository;

		public ConteudoService(ConteudoRepository repository)
		{
			_repository = repository;
		}

        public async Task<IEnumerable<Conteudo>> GetAllConteudos()
        {
            return await _repository.GetAll();
        }

        public async Task<Conteudo> GetConteudoById(int? id)
        {
            return await _repository.GetOne(id);
        }

        public async Task<int> Save(Conteudo conteudo)
        {
            return await _repository.SaveConteudo(conteudo);
        }

        public Task<Conteudo> Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public async Task<Conteudo> Details(int? id)
        {
            return await _repository.DetailsConteudo(id);
        }

        public Task<int> Edit(Conteudo conteudo)
        {
            throw new NotImplementedException();
        }
    }
}
