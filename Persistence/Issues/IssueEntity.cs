using System;
using System.ComponentModel.DataAnnotations;
using Persistence.Users;

namespace Persistence.Issues
{
    public class IssueEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }

        public UserEntity User { get; set; }
    }
}