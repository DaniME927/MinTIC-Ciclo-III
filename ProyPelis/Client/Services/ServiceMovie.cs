using System; 
using System.Collections.Generic;
using ProyPelis.Shared.Entity;

namespace ProyPelis.Client.Services
{
    public class ServiceMovie: IServiceMovie
    {
        public List<Movie>GetMovies(){
            return new List<Movie>(){
                new Movie(){MovieName="The Avengers", Image="/Images/Avengers.png", Category="Action", Synopsis="The director of the SHIELD Agency decides to recruit a team to save the world from almost certain disaster when an unexpected enemy emerges as a major threat to global security.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
                new Movie(){MovieName="Avengers: Age of Ultron", Image="/Images/Avengers2.jpg", Category="Action", Synopsis="This is the sequel to The Avengers.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
                new Movie(){MovieName="Avengers: Infinity War", Image="/Images/avengers-infinity-war.jpg", Category="Action", Synopsis="The superheroes team up to defeat the mighty Thanos, the worst enemy they have ever faced. If Thanos manages to gather the six gems of infinity: power, time, soul, reality, mind and space, no one will be able to stop him.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
                new Movie(){MovieName="Avengers: End Game", Image="/Images/Avengers-4.jpg", Category="Action", Synopsis="After the devastating events of Avengers: Infinity War, the universe is in ruins due to the actions of Thanos, the Mad Titan.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
                new Movie(){MovieName="Doctor Strange", Image="/Images/Strange.jpg", Category="Action", Synopsis="The life of the famous neurosurgeon Dr. Stephen Strange changes forever when a terrible car accident robs him of the use of his hands. When traditional medicine fails him, he seeks healing in a mysterious place called Kamar-Taj.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
                new Movie(){MovieName="Guardians of the Galaxy", Image="/Images/Galaxy.jpg", Category="Action", Synopsis="The reckless adventurer Peter Quill, after stealing a mysterious sphere coveted by Ronan, a powerful villain whose ambitions threaten the entire universe, becomes the most coveted prey of all the bounty hunters in the galaxy.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
                new Movie(){MovieName="Guardians of the Galaxy Vol.2", Image="/Images/Galaxy2.jpg", Category="Action", Synopsis="A powerful alien race hires the Guardians to protect their valuable power batteries, but when Rocket steals them, the aliens send their fighting troops to exact revenge on the Guardians. As they try to escape alive, they attempt to solve the mystery of Peter Quill's true origins.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
                new Movie(){MovieName="Spiderman: Homecoming", Image="/Images/Spiderman.jpg", Category="Action", Synopsis="Peter Parker decides to spend a well-deserved vacation in Europe with MJ, Ned and the rest of his friends. However, Peter must put on the Spider-Man suit again when Nick Fury entrusts him with a new mission.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
                new Movie(){MovieName="Iron Man", Image="/Images/IronMan.jpg", Category="Action", Synopsis="Tony Stark is an inventor of brilliant weaponry who is kidnapped abroad. His captors are terrorists who force him to build a destructive machine, but Tony will build armor so he can face them and escape.", ProductionCompany="Marvel Studios", ReleaseDate=new DateTime(2012,04,27)},
            };
        }
    }
}