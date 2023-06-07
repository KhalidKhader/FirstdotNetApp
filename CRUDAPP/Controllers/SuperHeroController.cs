using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDAPP.Models;
using CRUDAPP.Services.SuperHeroService;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return Ok(_superHeroService.GetAllHeroes());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var hero = _superHeroService.GetSingleHero(id);
            if (hero is null)
                return NotFound("not found !");
            return Ok(hero);
        }


    [HttpPost]
    public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
    {
        var result =_superHeroService.AddHero(hero);
        return Ok(result);

    }

    [HttpPut("{id}")]
        public async Task<ActionResult<SuperHero>> UpdateHero(int id, SuperHero request)
        {
            var result = _superHeroService.UpdateHero(id, request);
            if (result is null)
                return NotFound(" Hero Not Found ! ");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperHero>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            if (result is null)
                return NotFound(" Hero Not Found ! ");
            return Ok(result);

        }
    }
}

