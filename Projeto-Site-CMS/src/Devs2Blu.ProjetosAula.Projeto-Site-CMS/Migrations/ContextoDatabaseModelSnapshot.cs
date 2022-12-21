﻿// <auto-generated />
using System;
using Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Devs2Blu.ProjetosAula.ProjetoSiteCMS.Migrations
{
    [DbContext(typeof(ContextoDatabase))]
    partial class ContextoDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoriaNome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("categoria_nome");

                    b.HasKey("Id");

                    b.ToTable("categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaNome = "Embarcações"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaNome = "Automóveis"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaNome = "Motocicletas"
                        });
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.ConfiguracaoSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("contato");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("endereco");

                    b.Property<string>("NomeSite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_site");

                    b.HasKey("Id");

                    b.ToTable("configuracao_sistema");
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Conteudo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("CategoriaId");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_date");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descricao");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit")
                        .HasColumnName("is_published");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.Property<double>("Preco")
                        .HasColumnType("float")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("conteudo");
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ConteudoId")
                        .HasColumnType("int")
                        .HasColumnName("ConteudoId");

                    b.Property<string>("EnderecoImagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("endereco_imagem");

                    b.HasKey("Id");

                    b.HasIndex("ConteudoId");

                    b.ToTable("imagem");
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Newsletter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit")
                        .HasColumnName("ativo");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("newsletter");
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Conteudo", b =>
                {
                    b.HasOne("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Categoria", "Categoria")
                        .WithMany("Conteudo")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Imagem", b =>
                {
                    b.HasOne("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Conteudo", "Conteudo")
                        .WithMany("Imagem")
                        .HasForeignKey("ConteudoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conteudo");
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Categoria", b =>
                {
                    b.Navigation("Conteudo");
                });

            modelBuilder.Entity("Devs2Blu.ProjetosAula.Projeto_Site_CMS.Models.Entities.Conteudo", b =>
                {
                    b.Navigation("Imagem");
                });
#pragma warning restore 612, 618
        }
    }
}
