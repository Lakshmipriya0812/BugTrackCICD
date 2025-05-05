namespace BugTrack.Core.Entities
{
    public class AppUser
    {
        // Value types like int do not need to be marked 'required'
        public int Id { get; set; }

        // Using 'required' for non-nullable reference types
        public required string Username { get; set; }
        public required string Email { get; set; }

        // Initialize collections
        public required ICollection<Project> Projects { get; set; } = new List<Project>();
        public required ICollection<Bug> BugsReported { get; set; } = new List<Bug>();
        public required ICollection<Comment> Comments { get; set; } = new List<Comment>();

        // Optionally, initialize collections in the constructor if you prefer:
        // public AppUser()
        // {
        //     Projects = new List<Project>();
        //     BugsReported = new List<Bug>();
        //     Comments = new List<Comment>();
        // }
    }
}
