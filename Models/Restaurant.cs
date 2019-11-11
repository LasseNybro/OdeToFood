using System;
using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required,MaxLength(80)][Display(Name="Restaurant Name")]
        public String Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
