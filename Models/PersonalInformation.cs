using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TPLOCAL1.Models
{
    public class PersonalInformation
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Name")]
        [Required]
        public string? Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Forename { get; set; }

 
        [Required]
        public string? Gender { get; set; }
        public List<SelectListItem> Genders { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Select a Gender"},
            new SelectListItem { Value = "Male", Text = "Male" },
            new SelectListItem { Value = "Female", Text = "Female" },
            new SelectListItem { Value = "Other", Text = "Other"  },
        };

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Address { get; set; }

        [RegularExpression(@"\d{5}")]
        [Required]
        public string? ZipCode { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Town { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime StartDateTraining { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? TypeTraining { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? CobolTraining { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? TrainingPurpose { get; set; }


        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    }
}
