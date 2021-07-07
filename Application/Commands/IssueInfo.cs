using Persistence.Users;

namespace Application.Commands
{
    public class IssueInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string User { get; set; }
        
        public IssueInfo(string name, string description, string user)
        {
            Name = name;
            Description = description;
            User = user;
        }

        public IssueInfo() { }
    }
}