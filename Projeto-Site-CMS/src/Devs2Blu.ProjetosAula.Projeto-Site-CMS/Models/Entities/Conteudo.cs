using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities
{
	[Table("conteudo")]
	public class Conteudo
	{
		[Column("id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("nome")]
		[Display(Name = "Nome")]
		public string Nome { get; set; }

		[Column("descricao")]
		[Display(Name = "Descrição")]
		public string Descricao { get; set; }


		[Column("preco")]
		[Display(Name = "Preço")]
		public Double Preco { get; set; }

		[Column("CategoriaId")]
		[Display(Name = "Categoria")]
		public int CategoriaId { get; set;}

		public virtual Categoria? Categoria { get; set; }

		[Column("is_published")]
		[Display(Name = "Publicado?")]
		public bool IsPublished { get; set; }

		[Column("is_deleted")]
		[Display(Name = "Excluido?")]
		public bool IsDeleted { get; set; }

		[Column("created_date")]
		[Display(Name = "Data de Criação")]
		public DateTime CreatedDate { get; set; }

		public virtual ICollection<Imagem>? Imagem { get; set; }
	}
}
