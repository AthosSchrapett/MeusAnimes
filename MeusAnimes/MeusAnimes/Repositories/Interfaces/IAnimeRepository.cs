using MeusAnimes.Interfaces.Repositories;
using MeusAnimes.Models;

namespace MeusAnimes.Repositories.Interfaces;

public interface IAnimeRepository : IBaseRepository<Anime, Guid>
{
}
