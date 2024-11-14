using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PassportApplication.Models
{
    public class ApplicationUserGymClass
    {
        //Primary keys
        public string ApplicationUserId { get; set; }
        public int ClassId { get; set; }

        //Navigational properties
        public ApplicationUser ApplicationUser { get; set; }
        public GymClass GymClass { get; set; }
    }
}
