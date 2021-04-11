using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nxt_Level_Fitness.Models
{
    public class WeightWorkout
    {
        // F I E L D S & P R O P E R T I E S

        // [Display(Name = "Id")]
        // [MaxLength(40, ErrorMessage = "ID is Limited to 40 Characters")]
        // [Required(ErrorMessage = "ID Is Required")]
        public int Id { get; set; }

        //[Display(Name = "WeightWorkout")]
        [MaxLength(40, ErrorMessage = "Weight Workout is Limited to 40 Characters")]
        [Required(ErrorMessage = "Weight Workout Is Required")]
        public string WeightWorkouts { get; set; }

        //[Column(TypeName = "Date")]
        //[DataType(DataType.Date)]
        //[Display(Name ="Date")]
        //[UIHint("Date")]
        public string Date { get; set; }

        //[Display(Name = "Calories")]
        [Range(0, 5000, ErrorMessage = "Please enter a valid number")]
        [Column]
        [Required(ErrorMessage = "Calories Is Required")]
        public int Calories { get; set; }

        //[HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }

        // C O N S T R U C T O R S



        // M E T H O D S



    }
}
