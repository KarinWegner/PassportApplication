namespace PassportApplication.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public string Description { get; set; }

        //Navigational property

        public ICollection<ApplicationUserGymClass> Attendees { get; set; }
    }
}
