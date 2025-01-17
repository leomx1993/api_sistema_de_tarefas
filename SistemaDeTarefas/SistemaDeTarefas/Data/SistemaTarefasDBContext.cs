﻿using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.models;

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options)
        {
        }
            public DbSet<UsuarioModel> Usuarios { get; set; }
            public DbSet<UsuarioModel> Tarefas { get; set; }
            
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new UsuarioMap());
                modelBuilder.ApplyConfiguration(new TarefaMap());

                base.OnModelCreating(modelBuilder);
            }

    }
    
}
