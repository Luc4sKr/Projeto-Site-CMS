using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities
{
	[Table("imagem")]
	public class Imagem
	{
		[Column("id")]
		[Display(Name = "Código")]
		public int Id { get; set; }

		[Column("ConteudoId")]
		[Display(Name = "Conteudo")]
		public string ConteudoId { get; set; }

		public virtual Conteudo? Conteudo { get; set; }

		[Column("endereco_imagem")]
		[Display(Name = "Imagem")]
		public string EnderecoImagem { get; set; }
	}
}
