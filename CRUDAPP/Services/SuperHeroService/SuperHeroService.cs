using System;
using CRUDAPP.Models;

namespace CRUDAPP.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero{
                    Id=1,
                    FirstName="Khalid",
                    LastName="Khader",
                    Place="Tulkarm"
                },
                 new SuperHero{
                 Id=2,
                 FirstName="Ahmad",
                 LastName="Khader",
                 Place="Rammalah"
                },
                new SuperHero{
                    Id=3,
                    FirstName="Mohammad",
                    LastName="Khader",
                    Place="Rawabi"
                },
                 new SuperHero{
                 Id=4,
                 FirstName="Nasri",
                 LastName="Ladaa",
                 Place="Ramallah"
                },
            };

        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;
            superHeroes.Remove(hero);
            return superHeroes;
        }

        public List<SuperHero> GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero ? GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;
            return hero;
        }

        public List<SuperHero>? UpdateHero(int id, SuperHero request)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero is null)
                return null;

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            return superHeroes;

        }
    }
}

