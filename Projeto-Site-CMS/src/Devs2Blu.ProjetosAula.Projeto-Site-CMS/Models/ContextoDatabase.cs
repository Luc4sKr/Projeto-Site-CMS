using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models
{
	public class ContextoDatabase : DbContext
	{
		public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// Mapeamento de Relacionamento
			modelBuilder.Entity<Conteudo>()
				.HasOne(conteudo => conteudo.Categoria)
				.WithMany(categoria => categoria.Conteudo)
				.HasForeignKey(conteudo => conteudo.CategoriaId);

			modelBuilder.Entity<Imagem>()
				.HasOne(imagem => imagem.Conteudo)
				.WithMany(conteudo => conteudo.Imagem)
				.HasForeignKey(imagem => imagem.ConteudoId);

			// Seed
			modelBuilder.Entity<Categoria>()
				.HasData(
				new { Id = 1, CategoriaNome = "Embarcações" },
				new { Id = 2, CategoriaNome = "Automóveis" },
				new { Id = 3, CategoriaNome = "Motocicletas" }
				);
		}

		#region DBSets
		public DbSet<Categoria> Categoria { get; set; }
		public DbSet<Imagem> Imagem { get; set; }
		public DbSet<Conteudo> Conteudo { get; set; }
		public DbSet<ConfiguracaoSistema> ConfiguracaoSistema { get; set; }
		public DbSet<Newsletter> Newsletter { get; set; }

		#endregion
	}
}
