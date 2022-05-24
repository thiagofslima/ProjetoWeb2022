using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Repositorio.Entidades;

namespace Repositorio.Contexto
{
    public class EmpresaContext : DbContext
    {
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Produto> produto { get; set; }
        public DbSet<Pessoa> pessoa { get; set; }
        public DbSet<Funcionario> funcionario { get; set; }
        public EmpresaContext()
        {
            //Criar o database caso não exista
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var stringConexao = @"Server=RYZEN\SQLEXPRESS;DataBase=Empresa2022;integrated security=true;";

            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(stringConexao);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entidade =>
            {
                entidade.HasKey(e => e.id);
                entidade.Property(e => e.descricao).HasMaxLength(150);
            });

            modelBuilder.Entity<Produto>(entidade =>
            {
                //Chave primária
                entidade.HasKey(e => e.id);
                //Quantidade max caractéres e obrigatório
                entidade.Property(e => e.descricao).HasMaxLength(150);
                //Precisão de casas decimais
                entidade.Property(e => e.valor).HasPrecision(2);
                //Campo obrigatório
                entidade.Property(e => e.descricao).IsRequired();
                //Relacionamento
                entidade.HasOne(e => e.categoria) //Propriedade represente lado 1
                .WithMany(c => c.produtos)  //Prop lado MUITOS
                .HasForeignKey(e=>e.idCategoria) //Prop chave estrangeira
                .HasConstraintName("FK_Produto_Categoria") //Nome relacionamento
                .OnDelete(DeleteBehavior.NoAction); //Config da exclusão
            });

            modelBuilder.Entity<Pessoa>(entidade =>
            {
                entidade.HasKey(e => e.id);
                entidade.Property(e => e.nome).HasMaxLength(150);
                entidade.ToTable("Pessoa"); //Se quiser nome diferente, mas pega automático se não colocar
            });

            modelBuilder.Entity<Funcionario>(entidade =>
            {
                entidade.Property(e => e.salario).HasPrecision(8, 2);
                entidade.ToTable("Funcionario");
            });
        }
    }
}
