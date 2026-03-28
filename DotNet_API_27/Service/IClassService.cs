using DotNet_API_27.Entities.DTOs.ClassDTO;

namespace DotNet_API_27.Service
{
    public interface IClassService
    {
        Task<List<GetAllClassesDTO>> GetAll();
        Task<GetClassByIdDTO?> GetById(int id);
        Task<string> Create(CreateClassDTO dto);
        Task<string> Update(int id, UpdateClassDTO dto);
        Task<string> Delete(int id);
    }
}