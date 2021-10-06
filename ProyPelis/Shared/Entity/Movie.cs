using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ProyPelis.Shared.Entity
{
    public class Movie
    {
        public int Id {get;set;}
        [Required(ErrorMessage = "The field {0} is required")]
        public string MovieName{get;set;}
        public bool OnBillboard {get;set;}
        [Required(ErrorMessage = "The field {0} is required")]
        public string Image{get;set;}
        public string Category{get;set;}
         [Required(ErrorMessage = "The field {0} is required")]
        public string Trailer {get;set;}
         [Required(ErrorMessage = "The field {0} is required")]
        public string Synopsis{get;set;}
        [Required(ErrorMessage = "The field {0} is required")]
        public string ProductionCompany{get;set;}
        public DateTime ReleaseDate{get;set;}
         [Required(ErrorMessage = "The field {0} is required")]
        public List<Category> CategoriesMovie{get;set;} = new List<Category>();
        public string ShortName {
            get{
                if (string.IsNullOrWhiteSpace(MovieName))
                {
                    return null;
                }
                if (MovieName.Length > 60)
                {
                    return MovieName.Substring(0, 60) + "...";
                }else{
                    return MovieName;
                }
            }
        }
    }
}