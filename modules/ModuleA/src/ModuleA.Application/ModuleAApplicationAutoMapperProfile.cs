using AutoMapper;

namespace ModuleA
{
    public class ModuleAApplicationAutoMapperProfile : Profile
    {
        public ModuleAApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<TodoOne, TodoOneDto>();
            CreateMap<TodoOneDto, TodoOne>();
        }
    }
}