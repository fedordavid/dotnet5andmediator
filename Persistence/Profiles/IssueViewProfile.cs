using AutoMapper;
using Persistence.Issues;

namespace Persistence.Profiles
{
    public class IssueViewProfile : Profile
    {
        public IssueViewProfile()
        {
            CreateMap<IssueEntity, IssueView>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.User.Name));
        }
    }
}