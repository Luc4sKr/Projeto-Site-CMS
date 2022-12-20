using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities
{
	[Table("categoria")]
	public class Categoria
	{
		[Column("id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("categoria_nome")]
		[Display(Name = "Nome Categoria")]
		public string CategoriaNome { get; set; }

		public virtual ICollection<Conteudo>? Conteudo { get; set; }
	}
}
