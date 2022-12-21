using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Interfaces
{
    public interface IConteudoService
    {
        Task<IEnumerable<Conteudo>> GetAllConteudos();
        Task<Conteudo> GetConteudoById(int? id);
        Task<int> Save(Conteudo conteudo);
        Task<int> Edit(Conteudo conteudo);
        Task<Conteudo> Details(int? id);
        Task<Conteudo> Delete(int? id);
    }
}
