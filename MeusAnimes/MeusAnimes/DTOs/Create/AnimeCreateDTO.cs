using MeusAnimes.Models.Enums;

namespace MeusAnimes.DTOs.Create;

public record AnimeCreateDTO
(
    string Name, 
    string Description, 
    EnumGenero Genero,
    DateTime ReleaseDate, 
    EnumClassificacao Classificacao,
    byte[]? Perfil, 
    string? TrailerUrl
);
