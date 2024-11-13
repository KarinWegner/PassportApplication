using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PassportApplication.Models
{
    public class ApplicationUserGymClass
    {
        //Primary keys
        public int UserId { get; set; }
        public int ClassId { get; set; }

        public string UserName { get; set; }
        public string ClasssName { get; set; }

        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
        public ICollection<GymClass> GymClasses { get; set; }
    }
}
