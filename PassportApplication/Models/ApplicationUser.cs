using Microsoft.AspNetCore.Identity;

namespace PassportApplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        //Navigational property
        public ICollection<ApplicationUserGymClass> BookedClasses { get; set; }
    }
}
