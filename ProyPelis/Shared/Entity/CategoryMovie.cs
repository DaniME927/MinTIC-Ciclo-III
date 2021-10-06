using System;
using System.ComponentModel.DataAnnotations;
namespace ProyPelis.Shared.Entity
{
    public class CategoryMovie
    {
        public int Id {get;set;}
        /* Validamos que el campo nombre es requerido */
        [Required(ErrorMessage = "The field {0} is required")] 
        public string Category {get;set;}
    }
}