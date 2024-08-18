using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.GeneInfo;
using PM_Models.GeneInfo;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class GeneInfoRepo : IGeneInfo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GeneInfoRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<EmploymentStatusDTO> CreateEmpStatus(EmploymentStatusDTO empStatus)
        {
            var empStatusEntity = _mapper.Map<EmploymentStatusDTO ,EmploymentStatus>(empStatus);
            var addedEmp = await _context.EmploymentStatuses.AddAsync(empStatusEntity);
            await _context.SaveChangesAsync();
            return _mapper.Map<EmploymentStatus ,EmploymentStatusDTO>(addedEmp.Entity);
        }

        public async Task<EmploymentTypeDTO> CreateEmpType(EmploymentTypeDTO empType)
        {
            var empTypeEntity = _mapper.Map<EmploymentTypeDTO, EmploymentType>(empType);
            var addedEmp = await _context.EmploymentTypes.AddAsync(empTypeEntity);
            await _context.SaveChangesAsync();
            return _mapper.Map<EmploymentType, EmploymentTypeDTO>(addedEmp.Entity);
        }

        public async Task<bool> DeleteEmpStatus(int id)
        {
            var empStatus = await _context.EmploymentStatuses.FindAsync(id);
            if (empStatus == null)
            {
                return false;
            }
            _context.EmploymentStatuses.Remove(empStatus);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteEmpType(int id)
        {
            var empType = await _context.EmploymentTypes.FindAsync(id);
            if (empType == null)
            {
                return false;
            }
            _context.EmploymentTypes.Remove(empType);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<EmploymentStatusDTO>> GetAllEmpStatus()
        {
            var empStatuses = await _context.EmploymentStatuses.ToListAsync();
            return _mapper.Map<IEnumerable<EmploymentStatus>, IEnumerable<EmploymentStatusDTO>>(empStatuses);
        }

        public async Task<IEnumerable<EmploymentTypeDTO>> GetAllEmpType()
        {
            var empTypes = await _context.EmploymentTypes.ToListAsync();
            return _mapper.Map<IEnumerable<EmploymentType>, IEnumerable<EmploymentTypeDTO>>(empTypes);
        }
    }
}
