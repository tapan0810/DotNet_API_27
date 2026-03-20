using AutoMapper;
using DotNet_API_27.Entities.DTOs.ClassDTO;
using DotNet_API_27.Entities.Models;

namespace DotNet_API_27.Mapping
{
    public class ClassMappingProfile:Profile
    {
        public ClassMappingProfile(){

            CreateMap<Class, GetAllClassesDTO>();

            CreateMap<Class, GetClassByIdDTO>();

            CreateMap<CreateClassDTO, Class>();

            CreateMap<UpdateClassDTO, Class>();
        
        }
    }
}
