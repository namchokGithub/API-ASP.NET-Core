using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Data.EFCore
{
    public class EfCoreMovieRepository : EfCoreRepository<Movie, MyContext>
    {
        public EfCoreMovieRepository(MyDbContext context) : base(context)
        {

        }
        // We can add new methods specific to the movie repository here in the future
    }
}
