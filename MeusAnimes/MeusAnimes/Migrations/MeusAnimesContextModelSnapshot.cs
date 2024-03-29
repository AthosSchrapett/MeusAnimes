﻿// <auto-generated />
using System;
using MeusAnimes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MeusAnimes.Migrations
{
    [DbContext(typeof(MeusAnimesContext))]
    partial class MeusAnimesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MeusAnimes.Models.Anime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Classificacao")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<int>("Genero")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(500)");

                    b.Property<byte[]>("Perfil")
                        .HasColumnType("bytea");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp");

                    b.Property<string>("TrailerUrl")
                        .HasColumnType("varchar(500)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp");

                    b.HasKey("Id");

                    b.ToTable("Animes", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
