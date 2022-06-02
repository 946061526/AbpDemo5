using AutoMapper;

namespace AbpDemo5.Application
{
    public class AbpDemoAutoMapperProfile : Profile
    {
        public AbpDemoAutoMapperProfile()
        {
            //CreateMap<EditCategoryInput, Category>().ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}