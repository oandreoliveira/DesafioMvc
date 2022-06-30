using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ReceitasMvc.Models;

namespace ReceitasMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Medida> Medidas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<InsumoReceita> InsumoReceitas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
