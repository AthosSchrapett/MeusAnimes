using MeusAnimes.Data;
using MeusAnimes.Models;
using MeusAnimes.Repositories.Interfaces;

namespace MeusAnimes.Repositories.Implementations;

public class AnimeRepository(MeusAnimesContext meusAnimesContext) 
    : BaseRepository<Anime, Guid>(meusAnimesContext), IAnimeRepository
{
}
