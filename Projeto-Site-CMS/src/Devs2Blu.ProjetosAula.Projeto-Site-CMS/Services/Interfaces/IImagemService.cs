using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Services.Interfaces
{
    public interface IImagemService
    {
        Task<IEnumerable<Imagem>> GetAllImagens();
    }
}
