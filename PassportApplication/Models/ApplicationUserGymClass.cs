using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportApplication.Models
{
    public class ApplicationUserGymClass
    {
        //Primary keys
        public string ApplicationUserId { get; set; }
        public int GymClassId { get; set; }

        //Navigational properties
        public ApplicationUser ApplicationUser { get; set; }
        public GymClass GymClass { get; set; }
    }
}
