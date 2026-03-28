using AutoMapper;
using DotNet_API_27.Data;
using DotNet_API_27.Entities.DTOs.ClassDTO;
using DotNet_API_27.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_API_27.Service
{
    public class ClassService : IClassService
    {
        private readonly ClassDbContext _context;
        private readonly IMapper _mapper;

        public ClassService(ClassDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetAllClassesDTO>> GetAll()
        {
            var data = await _context.Classes.ToListAsync();
            return _mapper.Map<List<GetAllClassesDTO>>(data);
        }

        public async Task<GetClassByIdDTO?> GetById(int id)
        {
            var data = await _context.Classes.FindAsync(id);
            if (data == null) return null;

            return _mapper.Map<GetClassByIdDTO>(data);
        }

        public async Task<string> Create(CreateClassDTO dto)
        {
            var entity = _mapper.Map<Class>(dto);
            await _context.Classes.AddAsync(entity);
            await _context.SaveChangesAsync();

            return "Created Successfully";
        }

        public async Task<string> Update(int id, UpdateClassDTO dto)
        {
            var data = await _context.Classes.FindAsync(id);
            if (data == null) return "Not Found";

            _mapper.Map(dto, data);
            await _context.SaveChangesAsync();

            return "Updated Successfully";
        }

        public async Task<string> Delete(int id)
        {
            var data = await _context.Classes.FindAsync(id);
            if (data == null) return "Not Found";

            _context.Classes.Remove(data);
            await _context.SaveChangesAsync();

            return "Deleted Successfully";
        }
    }
}