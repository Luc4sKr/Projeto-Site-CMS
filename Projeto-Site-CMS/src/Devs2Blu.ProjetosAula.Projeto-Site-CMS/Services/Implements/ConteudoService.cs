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
	}
}
