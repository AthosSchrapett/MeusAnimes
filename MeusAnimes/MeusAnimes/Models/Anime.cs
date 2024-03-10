using MeusAnimes.Models.Enums;

namespace MeusAnimes.Models;

public class Anime
(
    string name,
    string? description,
    EnumGenero genero,
    DateTime releaseDate,
    EnumClassificacao classificacao,
    byte[]? perfil,
    string? trailerUrl
) : BaseModel
{
    public string Name { get; private set; } = name;
    public string? Description { get; private set; } = description;
    public EnumGenero Genero { get; private set; } = genero;
    public EnumClassificacao Classificacao { get; private set; } = classificacao;
    public DateTime ReleaseDate { get; private set; } = releaseDate;
    public byte[]? Perfil { get; private set; } = perfil;
    public string? TrailerUrl { get; private set; } = trailerUrl;

    public void Update
    (
        string name,
        string? description,
        EnumGenero genero,
        EnumClassificacao classificacao,
        DateTime releaseDate,
        byte[]? perfil,
        string? trailerUrl
    )
    {
        Name = name;
        Description = description;
        Genero = genero;
        Classificacao = classificacao;
        ReleaseDate = releaseDate;
        Perfil = perfil;
        TrailerUrl = trailerUrl;
        UpdateBase();
    }
}
