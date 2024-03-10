using MeusAnimes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeusAnimes.Configurations;

public class AnimeConfiguration : IEntityTypeConfiguration<Anime>
{
    public void Configure(EntityTypeBuilder<Anime> builder)
    {
        builder.ToTable("Animes");

        #region BaseEntity
        builder.HasKey(a => a.Id);
        builder.Property(a => a.CreatedAt).IsRequired().HasColumnType("timestamp");
        builder.Property(a => a.UpdatedAt).IsRequired().HasColumnType("timestamp");
        builder.Property(a => a.IsActive).IsRequired();
        #endregion

        builder.Property(a => a.Name).IsRequired().HasColumnType("varchar(500)");
        builder.Property(a => a.Description).IsRequired().HasColumnType("varchar(500)");
        builder.Property(a => a.Genero).IsRequired().HasConversion<int>();
        builder.Property(a => a.Classificacao).IsRequired().HasConversion<int>();
        builder.Property(a => a.ReleaseDate).IsRequired().HasColumnType("timestamp");
        builder.Property(a => a.Perfil).HasColumnType("bytea");
        builder.Property(a => a.TrailerUrl).HasColumnType("varchar(500)");
    }
}
