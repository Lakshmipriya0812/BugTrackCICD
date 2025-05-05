using System;

namespace BugTrack.Core.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public required string Message { get; set; }
        public DateTime CreatedAt { get; set; }

        public int BugId { get; set; }
        public required Bug Bug { get; set; }

        public int AuthorId { get; set; }
        public required AppUser Author { get; set; }
    }
}
