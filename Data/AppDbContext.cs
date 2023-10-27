using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto_Autenticacao_Usuario__C_.Models;

namespace Projeto_Autenticacao_Usuario__C_.Data
{
    public class AppDbContext :  IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {        
        }

        public DbSet<AreaAtuacao> AreasAtuacoes { get; set; }
        public DbSet<Usuario> Usuarios {get;set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region Popular Areas de Atuacao
            List<AreaAtuacao> areas = new(){
                new(){
                    Id = 1,
                    Nome = "Desenvolvedor FullStack"
                }, 
                new(){
                    Id = 2,
                    Nome = "Desenvolvedor BackEnd"
                },
                new(){
                    Id = 3,
                    Nome = "Desenvolvedor FrontEnd"
                }
            };
            builder.Entity<AreaAtuacao>().HasData(areas);
            #endregion

            #region Popular Usuario
            

            #endregion
        }
    }
}