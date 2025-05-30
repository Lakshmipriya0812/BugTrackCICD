namespace BugTrack.Core.Entities
{
    public class Bug
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Status { get; set; } // e.g., Open, In Progress, Closed

        public int ProjectId { get; set; }
        public required Project Project { get; set; }

        public int ReporterId { get; set; }
        public required AppUser Reporter { get; set; }

        public required ICollection<Comment> Comments { get; set; }
    }
}
