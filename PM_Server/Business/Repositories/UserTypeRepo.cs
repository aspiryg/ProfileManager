using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.UserProfiles;
using PM_Models.UserProfilesModels;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class UserTypeRepo : IUserTypeRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UserTypeRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserTypeDTO> CreateUserType(UserTypeDTO userType)
        {
            var userTypeObj = _mapper.Map<UserTypeDTO, UserType>(userType);
            userTypeObj.CreatedDate = DateTime.Now;
            var CreatedUserType = await _context.UserTypes.AddAsync(userTypeObj);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserType, UserTypeDTO>(CreatedUserType.Entity);
        }

        public async Task<UserTypeDTO> DeleteUserType(int id)
        {
            var userType = await _context.UserTypes.FindAsync(id);
            if (userType == null)
            {
                return new UserTypeDTO();
            }
            userType.IsDeleted = true;
            userType.ModifiedDate = DateTime.Now;
            var userTypeDeleted = _context.UserTypes.Update(userType);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserType, UserTypeDTO>(userTypeDeleted.Entity);
        }

        public async Task<UserTypeDTO> GetUserType(int id)
        {
            var userType = await _context.UserTypes.FindAsync(id);
            if (userType == null)
            {
                return new UserTypeDTO();
            }
            return _mapper.Map<UserType, UserTypeDTO>(userType);
        }

        public async Task<IEnumerable<UserTypeDTO>> GetUserTypes()
        {
            var userTypes = await _context.UserTypes.ToListAsync();
            if (userTypes == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<UserType>, IEnumerable<UserTypeDTO>>(userTypes);
        }

        public async Task<UserTypeDTO> UpdateUserType(UserTypeDTO userType)
        {
            var userTypeToUpdate = await _context.UserTypes.FindAsync(userType.ID);
            if (userTypeToUpdate == null)
            {
                return new UserTypeDTO();
            }
            userTypeToUpdate.Type = userType.Type;
            userTypeToUpdate.Description = userType.Description;
            userTypeToUpdate.ModifiedDate = DateTime.Now;
            var userTypeUpdated = _context.UserTypes.Update(userTypeToUpdate);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserType, UserTypeDTO>(userTypeUpdated.Entity);
        }
    }
}
