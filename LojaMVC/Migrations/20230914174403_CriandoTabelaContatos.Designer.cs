﻿// <auto-generated />
using LojaMVC.NovaPasta1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LojaMVC.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20230914174403_CriandoTabelaContatos")]
    partial class CriandoTabelaContatos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LojaMVC.NovaPasta1.ProdutoDB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("NomeProduto");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProdutoDB");
                });
#pragma warning restore 612, 618
        }
    }
}
