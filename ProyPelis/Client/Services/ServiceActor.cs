using System.Security.AccessControl;
using System; 
using System.Collections.Generic;
using ProyPelis.Shared.Entity;

namespace ProyPelis.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List<Actor> GetActors(){
            return new List<Actor>{
                new Actor(){ActorName = "Scarlet Johanson", Photo = "/Images/Actor1.jpg", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Female, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Chris Hemsworth", Photo = "/Images/Actor2.jpg", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Chris Evans", Photo = "/Images/Actor3.png", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Robert Downey jr", Photo = "/Images/Actor4.jpg", DocumentType = DocumentType.ForeignerID, Document = "105387", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Zoe Saldana", Photo = "/Images/Actor5.jpg", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Female, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Tom Hidleston", Photo = "/Images/Actor6.jpeg", DocumentType = DocumentType.ForeignerID, Document = "105387", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Mark Ruffalo", Photo = "/Images/Actor7.jpg", DocumentType = DocumentType.PassPort, Document = "90538766", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Tom Holland", Photo = "/Images/Actor8.jpg", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Chadwick Boseman", Photo = "/Images/Actor9.jpeg", DocumentType = DocumentType.PassPort, Document = "90538766", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Gwyneth Paltrow", Photo = "/Images/Actor10.jpeg", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Female, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."}
            };
        }
    }
}