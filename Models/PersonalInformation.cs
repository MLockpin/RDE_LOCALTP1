using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class PersonalInformation
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Forename { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Gender { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Adress { get; set; }

        [StringLength(5)]
        [Required]
        public string? ZipCode { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Town { get; set; }

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
