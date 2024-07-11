using AutoMapper;

namespace _1.AutoMapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookDTO>().ReverseMap();
            CreateMap<Source, Destination>()
                .IncludeMembers(s => s.InnerSource, s => s.OtherInnerSource);
            CreateMap<InnerSource, Destination>(MemberList.None);
            CreateMap<OtherInnerSource, Destination>();
        }
    }
}