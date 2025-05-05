namespace BugTrack.Core.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        public int OwnerId { get; set; }
        public required AppUser Owner { get; set; }

        public required ICollection<Bug> Bugs { get; set; }
    }
}
