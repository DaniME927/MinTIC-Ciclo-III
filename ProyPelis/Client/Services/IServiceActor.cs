using System.Collections.Generic;
using ProyPelis.Shared.Entity;

namespace ProyPelis.Client.Services
{
    public interface IServiceActor
    {
        List<Actor> GetActors();
    }
}