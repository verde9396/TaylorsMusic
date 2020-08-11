using System.Collections.Generic;
using System.Data;
using System.Linq;
using TaylorsMuic.Data.Models;

namespace TaylorsMuic.Data.Services
{
    public class InMemoryHerData : IHerData
    {
        List<Her> hers;
        public InMemoryHerData()
        {
            hers = new List<Her>()
            {
                new Her{ Id = 1,Album = Albums.Red, Name = "State of grace", Genre = MusicGenres.Country},
                new Her {Id = 2,Album = Albums.One, Name = "Welcome to NewYork", Genre = MusicGenres.Pop},
                new Her {Id = 3, Album =Albums.Reputation, Name ="Ready for it", Genre= MusicGenres.Pop},
                new Her{Id = 4, Album = Albums.Lover, Name="I forgot that you existed", Genre= MusicGenres.Rock},
                new Her{Id = 5, Album = Albums.Folklore, Name= "The 1", Genre = MusicGenres.Folk}
            };
        }
        public IEnumerable<Her> GetAll()
        {
            return hers.OrderBy(r => r.Name);
        }
    }
}
