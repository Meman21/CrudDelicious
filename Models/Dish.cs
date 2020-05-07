using System;
using System.ComponentModel.DataAnnotations;

namespace CrudDelicious
{public class Dish
    {
       [Key]
       public int DishId {get;set;}
       [Required]
       [Display(Name="Chef's Name")]
       public string Chef {get;set;}
       [Required]
       [Display(Name="Name of Dish")]
       public string Name {get;set;}
       [Required]
       [Range(0, Int32.MaxValue, ErrorMessage = "Calories must be at least 1")]
       [Display(Name="# of Calories")]
       public int Calories {get;set;}
       [Required]
       public int Tastiness {get;set;}
       [Required]
       public string Description {get;set;}
       public DateTime CreatedAt {get;set;} = DateTime.Now;
       public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}