using System;
using System.ComponentModel.DataAnnotations;
namespace ProyPelis.Shared.Entity
{
    public class CategoryMovie
    {
        public int ID {get;set;}
        /* Validamos que el campo nombre es requerido */
        [Required(ErrorMessage = "El campo {0} es requerido")] 
        public string Category {get;set;}
    }
}