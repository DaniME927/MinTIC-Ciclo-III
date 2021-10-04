using System.Collections.Generic;
using ProyPelis.Shared.Entity;

namespace ProyPelis.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
        /* List<Actors> GetActors(); */
    }
}