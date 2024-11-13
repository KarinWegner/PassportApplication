namespace PassportApplication.Models.ViewModels
{
    public class CreateUserViewModel
    {public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationTime { get; set; }

        public CreateUserViewModel() {
            this.RegistrationTime = DateTime.Now;
        }
    }
}
