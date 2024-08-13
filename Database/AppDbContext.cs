﻿using MesaLivre.Models;
using Microsoft.EntityFrameworkCore;

namespace MesaLivre.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {}

    public DbSet<Restaurante> Restaurantes  { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Telefone> Telefones { get; set; }
    public DbSet<TelefoneTipo> TelefoneTipos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurante>()
            .HasOne(r => r.Endereco)
            .WithOne()
            .HasForeignKey<Restaurante>(r => r.EnderecoID);
    }
}
