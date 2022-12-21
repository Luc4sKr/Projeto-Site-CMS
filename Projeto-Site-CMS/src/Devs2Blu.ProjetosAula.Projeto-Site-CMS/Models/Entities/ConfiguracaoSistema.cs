using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities
{
	[Table("configuracao_sistema")]
	public class ConfiguracaoSistema
	{
		[Column("id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("nome_site")]
		[Display(Name = "Nome Site")]
		public string NomeSite { get; set; }

		[Column("contato")]
		[Display(Name = "Contato")]
		public string Contato { get; set; }

		[Column("endereco")]
		[Display(Name = "Endereço")]
		public string Endereco { get; set; }
	}
}
