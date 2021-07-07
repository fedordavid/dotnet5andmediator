using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Persistence.Issues;

namespace Persistence.Users
{
    public class UserEntity
    {
        [Key] 
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<IssueEntity> Issue { get; set; }
    }
}