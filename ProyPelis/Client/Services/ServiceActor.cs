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
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.ForeignerID, Document = "105387", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.ForeignerID, Document = "105387", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.PassPort, Document = "90538766", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.PassPort, Document = "90538766", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."},
                new Actor(){ActorName = "Actor 1", DocumentType = DocumentType.CitizenshipCard, Document = "1053876654", Gender = Gender.Male, Birthdate = new DateTime(1992,09,26), KnowCredits = 10, Nominations = 4, Biography = "Life..."}
            };
        }
    }
}