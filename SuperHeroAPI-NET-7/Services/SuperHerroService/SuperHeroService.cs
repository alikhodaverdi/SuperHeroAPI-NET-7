namespace SuperHeroAPI_NET_7.Services.SuperHerroService
{
    public class SuperHeroService : ISuperHeroService
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
        public List<SuperHero> AddHero(SuperHero hero)
        {
            throw new NotImplementedException();
        }

        public List<SuperHero> DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHero> GetAllHeroes()
        {
            throw new NotImplementedException();
        }

        public SuperHero GetSingleHero(int id)
        {
            throw new NotImplementedException();
        }

        public List<SuperHero> UpdateHero(int id, SuperHero request)
        {
            throw new NotImplementedException();
        }

    }
}
