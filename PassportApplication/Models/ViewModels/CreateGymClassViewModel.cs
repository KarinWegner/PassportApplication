using System.ComponentModel.DataAnnotations;

namespace PassportApplication.Models.ViewModels
{
    public class CreateGymClassViewModel
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public DateTime StartTime { get; set; }
        [Required(ErrorMessage ="Number of hours required. If shorter, enter 0")]
        [StringLength(2, MinimumLength =1)]
        [Display(Name ="Hours")]
        public string DurationHours { get; set; }

        [Required(ErrorMessage = "Number of minutes required. If whole hour, enter 0")]
        [StringLength(2, MinimumLength = 1)]
        [Display(Name ="Minutes")]
        public string DurationMinutes { get; set; }
        [StringLength(200, MinimumLength =1)]
        public string Description { get; set; }
    }
}
