using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities
{
	[Table("newsletter")]
	public class Newsletter
	{
		[Column("id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("nome")]
		[Display(Name = "Nome")]
		public string Nome { get; set; }

		[Column("email")]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Column("ativo")]
		[Display(Name = "Ativo")]
		public bool Ativo { get; set; }
	}
}
