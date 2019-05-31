using System;
using System.Collections.Generic;

namespace Todos_Infrastructure.EF
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsEmergency { get; set; }
        public bool IsDeleted { get; set; }

        public ApplicationUser CreatedByUser { get; set; }

        public ApplicationUser CreatedForUser { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
