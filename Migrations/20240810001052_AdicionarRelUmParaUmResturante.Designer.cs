﻿// <auto-generated />
using System;
using MesaLivre.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MesaLivre.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240810001052_AdicionarRelUmParaUmResturante")]
    partial class AdicionarRelUmParaUmResturante
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MesaLivre.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("MesaLivre.Models.Restaurante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EnderecoID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("HoraAbertura")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraFechamento")
                        .HasColumnType("time");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoID")
                        .IsUnique();

                    b.ToTable("Restaurantes");
                });

            modelBuilder.Entity("MesaLivre.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestauranteID")
                        .HasColumnType("int");

                    b.Property<int>("TelefoneTipoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoTelefoneID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestauranteID");

                    b.HasIndex("TelefoneTipoId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("MesaLivre.Models.TelefoneTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TelefoneTipos");
                });

            modelBuilder.Entity("MesaLivre.Models.Restaurante", b =>
                {
                    b.HasOne("MesaLivre.Models.Endereco", "Endereco")
                        .WithOne()
                        .HasForeignKey("MesaLivre.Models.Restaurante", "EnderecoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("MesaLivre.Models.Telefone", b =>
                {
                    b.HasOne("MesaLivre.Models.Restaurante", "Restaurante")
                        .WithMany("Telefones")
                        .HasForeignKey("RestauranteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MesaLivre.Models.TelefoneTipo", "TelefoneTipo")
                        .WithMany()
                        .HasForeignKey("TelefoneTipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurante");

                    b.Navigation("TelefoneTipo");
                });

            modelBuilder.Entity("MesaLivre.Models.Restaurante", b =>
                {
                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
