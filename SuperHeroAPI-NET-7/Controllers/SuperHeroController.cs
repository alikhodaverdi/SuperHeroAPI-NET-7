using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI_NET_7.Models;

namespace SuperHeroAPI_NET_7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                },
                new SuperHero
                {
                    Id = 2,
                    Name = "Iron Man",
                    FirstName = "Tony",
                    LastName = "Stark",
                    Place = "Malibu"
                }
            };
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
       
            return Ok(superHeroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x=>x.Id == id);  
            if(hero is null) 
                return NotFound("Sorry , doesn't exist.");
            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero([FromBody]SuperHero hero)
        {
            superHeroes.Add(hero);
            return Ok(superHeroes);
        }
    }
}
