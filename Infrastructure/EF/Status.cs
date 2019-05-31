using System.Collections.Generic;

namespace Todos_Infrastructure.EF
{
    public class Status
    {
        public int StatusId { get; set; }
        public string Name { get; set; }

        public ICollection<Relationship> Relationships { get; set; }
    }
}
