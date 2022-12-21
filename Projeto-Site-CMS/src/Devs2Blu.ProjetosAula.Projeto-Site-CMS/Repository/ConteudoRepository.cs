using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Repository
{
	public class ConteudoRepository
	{
		private readonly ContextoDatabase _context;
		public ConteudoRepository(ContextoDatabase contexto)
		{
			_context = contexto;
		}

		#region Select

		public async Task<IEnumerable<Conteudo>> GetAll()
		{
			return await _context.Conteudo.ToListAsync();
		}

		#endregion

	}


}
