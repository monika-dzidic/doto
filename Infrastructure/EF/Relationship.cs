using System;

namespace Todos_Infrastructure.EF
{
    public class Relationship
    {
        public int RelationshipId { get; set; }
        public DateTime RequestDate { get; set; }

        public ApplicationUser SentByUser { get; set; }

        public ApplicationUser SentToUser { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
