using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todos_Infrastructure.EF
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastLoginDateTime { get; set; }

        [InverseProperty("CreatedByUser")]
        public ICollection<Todo> Todos { get; set; }

        [InverseProperty("CreatedForUser")]
        public ICollection<Todo> CreatedForTodos { get; set; }

        [InverseProperty("SentByUser")]
        public ICollection<Relationship> SentRelationshipRequests { get; set; }

        [InverseProperty("SentToUser")]
        public ICollection<Relationship> ReceivedRelationshipRequests { get; set; }
    }
}
