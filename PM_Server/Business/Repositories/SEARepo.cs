using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.SEA;
using PM_Models.SEA;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class SEARepo : ISEAssessment
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public SEARepo(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<SocioeconomicAssessmentDTO> AddSEA(SocioeconomicAssessmentDTO sea)
        {
            var newSEA = _mapper.Map<SocioeconomicAssessmentDTO, SocioeconomicAssessment>(sea);
            newSEA.CreatedDate = DateTime.Now;
            var AddedSEA = await _context.SEAssessments.AddAsync(newSEA);
            await _context.SaveChangesAsync();
            return _mapper.Map<SocioeconomicAssessment, SocioeconomicAssessmentDTO>(AddedSEA.Entity);
        }

        public async Task<bool> DeleteSEA(int id)
        {
            var sea = await _context.SEAssessments.FindAsync(id);
            if (sea == null)
            {
                return false;
            }
            _context.SEAssessments.Remove(sea);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteSEAByPatientID(int patientID)
        {
            var sea = await _context.SEAssessments.FirstOrDefaultAsync(s => s.PatientID == patientID);
            if (sea == null)
            {
                return false;
            }
            _context.SEAssessments.Remove(sea);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<SocioeconomicAssessmentDTO> GetSEA(int id)
        {
            var sea = await _context.SEAssessments.FindAsync(id);
            if (sea == null)
            {
                return new SocioeconomicAssessmentDTO();
            }
            return _mapper.Map<SocioeconomicAssessment, SocioeconomicAssessmentDTO>(sea);
        }

        public async Task<SocioeconomicAssessmentDTO> GetSEAByPatientID(int patientID)
        {
            var sea = await _context.SEAssessments.FirstOrDefaultAsync(s => s.PatientID == patientID);
            if (sea == null)
            {
                return new SocioeconomicAssessmentDTO();
            }
            return _mapper.Map<SocioeconomicAssessment, SocioeconomicAssessmentDTO>(sea);
        }

        public async Task<IEnumerable<SocioeconomicAssessmentDTO>> GetSEAs()
        {
            var seas = await _context.SEAssessments.ToListAsync();
            if (seas == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<SocioeconomicAssessment>, IEnumerable<SocioeconomicAssessmentDTO>>(seas);
        }

        public async Task<bool> SEAExists(int id)
        {
            return await _context.SEAssessments.AnyAsync(s => s.Id == id);
        }

        public async Task<bool> SEAExistsByPatientID(int patientID)
        {
            return await _context.SEAssessments.AnyAsync(s => s.PatientID == patientID);
        }

        public async Task<SocioeconomicAssessmentDTO> UpdateSEA(SocioeconomicAssessmentDTO sea)
        {
            var seaToUpdate = await _context.SEAssessments.FindAsync(sea.Id);
            if (seaToUpdate == null)
            {
                return new SocioeconomicAssessmentDTO();
            }
            _mapper.Map(sea, seaToUpdate);
            seaToUpdate.ModifiedDate = DateTime.Now;
            _context.SEAssessments.Update(seaToUpdate);
            await _context.SaveChangesAsync();
            return _mapper.Map<SocioeconomicAssessment, SocioeconomicAssessmentDTO>(seaToUpdate);
        }
    }
}
