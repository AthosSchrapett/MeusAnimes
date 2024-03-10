using MeusAnimes.DTOs.Create;
using MeusAnimes.Mapper;
using MeusAnimes.Models;
using MeusAnimes.Models.Enums;
using MeusAnimes.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace MeusAnimes.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AnimesController(IAnimeRepository animeRepository) : ControllerBase
{
    private readonly IAnimeRepository _animeRepository = animeRepository;

    [HttpGet]
    public IEnumerable<Anime>? Get()
    {
        return _animeRepository.GetAll();
    }

    [HttpGet("{id}")]
    public Anime? Get(Guid id)
    {
        return _animeRepository.GetById(id);
    }

    [HttpPost]
    public void Post([FromBody] AnimeCreateDTO dto)
    {
        Anime anime = dto.Map();
        _animeRepository.Add(anime);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
