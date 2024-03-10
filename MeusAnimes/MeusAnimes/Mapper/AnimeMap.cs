using MeusAnimes.DTOs.Create;
using MeusAnimes.Models;

namespace MeusAnimes.Mapper;

public static class AnimeMap
{
    public static Anime Map(this AnimeCreateDTO dto) => new
    (
        dto.Name,
        dto.Description,
        dto.Genero,
        dto.ReleaseDate,
        dto.Classificacao,
        dto.Perfil,
        dto.TrailerUrl
    );
}
