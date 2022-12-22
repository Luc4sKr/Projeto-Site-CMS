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
			return _context.Conteudo.ToList();
		}

		public async Task<Conteudo> GetOne(int? id)
		{
			return await _context.Conteudo.FirstOrDefaultAsync(conteudo => conteudo.Id == id);
		}

		public async Task<int> SaveConteudo(Conteudo conteudo)
		{
			_context.Add(conteudo);
			return await _context.SaveChangesAsync();
		}

		public async Task<Conteudo> DetailsConteudo(int? id)
		{
            return await _context.Conteudo
                .Include(conteudo => conteudo.Categoria)
                .FirstOrDefaultAsync(conteudo => conteudo.Id == id);
        }
		#endregion

	}


}
