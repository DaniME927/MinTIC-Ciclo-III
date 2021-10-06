using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;

namespace ProyPelis.Shared.Entity
{
    public class Actor
    {
        public int Id {get;set;}
        [Required(ErrorMessage = "The field {0} is required")]
        public string ActorName {get;set;}
        public string Photo{get;set;}
        public DocumentType DocumentType {get;set;}
        public string Document {get;set;}
        public Gender Gender {get;set;}
        [Required(ErrorMessage = "The field {0} is required")]
        public DateTime Birthdate {get;set;}
        public int KnowCredits {get;set;}
        public int Nominations {get;set;}
        public string Biography {get;set;}
    }

    public enum DocumentType{
        CitizenshipCard = 0,
        ForeignerID = 1,
        PassPort = 2,
        CivilRegistration = 3
    }

    public enum Gender{
        Female = 0,
        Male = 1
    }
}