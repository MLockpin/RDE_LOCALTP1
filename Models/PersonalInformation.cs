using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TPLOCAL1.Models
{
    public class PersonalInformation
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Name length have to be between 3 and 60 characters.")]
        [Display(Name = "Name")]
        [Required]
        public string? Name { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Forename length have to be between 3 and 60 characters.")]
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

        [RegularExpression(@"\d{5}", ErrorMessage = "Zip Code have to be with 5 numbers.")]
        [Required]
        public string? ZipCode { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Town { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Release Date")]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2021", ErrorMessage = "Date have to be between 01/01/1900 and 01/01/2021.")]
        public DateTime StartDateTraining { get; set; }

        [Required]
        public string? TypeTraining { get; set; }
        public List<SelectListItem> TypesTraining { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "", Text = "Select a course"},
            new SelectListItem { Value = "Cobol", Text = "Cobol Training" },
            new SelectListItem { Value = "C#", Text = "Object training" },
            new SelectListItem { Value = "Dual", Text = "Dual Skills Training"  },
        };

        [StringLength(60, MinimumLength = 3)]

        public string? CobolTraining { get; set; }

        [StringLength(60, MinimumLength = 3)]
 
        public string? TrainingPurpose { get; set; }

    }
}
