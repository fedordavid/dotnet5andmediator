using System;
using System.ComponentModel.DataAnnotations;

namespace Persistence.Issues
{
    public class IssueEntity
    {
        [Key]
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
    }
}