using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PM_DataAccess.UserProfiles;
using PM_Models.UserProfilesModels;
using PM_Server.Business.Repositories.IRepo;
using PM_Server.Data;

namespace PM_Server.Business.Repositories
{
    public class UserProfileRepo : IUserProfileRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UserProfileRepo(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<UserProfileDTO> CreateUserProfile(UserProfileDTO user)
        {
            var userObj = _mapper.Map<UserProfileDTO, UserProfile>(user);
            userObj.CreatedDate = DateTime.Now;
            var CreatedUser = await _context.UserProfiles.AddAsync(userObj);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserProfile, UserProfileDTO>(CreatedUser.Entity);
        }

        public async Task<UserProfileDTO> DeleteUserProfile(int userID)
        {
            var user = await _context.UserProfiles.FindAsync(userID);
            if (user == null)
            {
                return new UserProfileDTO();
            }
            user.IsDeleted = true;
            user.ModifiedDate = DateTime.Now;
            var userDeleted = _context.UserProfiles.Update(user);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserProfile, UserProfileDTO>(userDeleted.Entity);
        }

        public async Task<IEnumerable<UserProfileDTO>> GetAllUserProfiles()
        {
            var users = await _context.UserProfiles.ToListAsync();
            if (users == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<UserProfile>, IEnumerable<UserProfileDTO>>(users);
        }

        public async Task<UserProfileDTO> GetUserByEmail(string email)
        {
            var user = await _context.UserProfiles.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return new UserProfileDTO();
            }
            return _mapper.Map<UserProfile, UserProfileDTO>(user);
        }

        public async Task<IEnumerable<UserProfileDTO>> GetUserByRole(string role)
        {
            var users = await _context.UserProfiles.Where(u => u.Role == role).ToListAsync();
            if (users == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<UserProfile>, IEnumerable<UserProfileDTO>>(users);
        }

        public async Task<IEnumerable<UserProfileDTO>> GetUserByType(string type)
        {
            var users = await _context.UserProfiles.Where(u => u.UserType == type).ToListAsync();
            if (users == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<UserProfile>, IEnumerable<UserProfileDTO>>(users);
        }

        public async Task<UserProfileDTO> GetUserProfile(int userID)
        {
            var user = await _context.UserProfiles.FindAsync(userID);
            if (user == null)
            {
                return new UserProfileDTO();
            }
            return _mapper.Map<UserProfile, UserProfileDTO>(user);
        }

        public async Task<UserProfileDTO> GetUserProfileByCode(Guid userCode)
        {
            var user = await _context.UserProfiles.FirstOrDefaultAsync(u => u.UserID == userCode);
            if (user == null)
            {
                return new UserProfileDTO();
            }
            return _mapper.Map<UserProfile, UserProfileDTO>(user);
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

        public async Task<int> RemoveUser(int userID)
        {
            var user = await _context.UserProfiles.FindAsync(userID);
            if (user == null)
            {
                return 0;
            }
            _context.UserProfiles.Remove(user);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserProfileDTO>> SearchUserProfiles(string name)
        {
            var users = await _context.UserProfiles.Where(u => u.FirstName.Contains(name) || u.MiddleName.Contains(name) || u.LastName.Contains(name)).ToListAsync();
            if (users == null)
            {
                return [];
            }
            return _mapper.Map<IEnumerable<UserProfile>, IEnumerable<UserProfileDTO>>(users);
        }

        public async Task<UserProfileDTO> UpdateUserProfile(UserProfileDTO user)
        {
            var userToUpdate = await _context.UserProfiles.FindAsync(user.ID);
            if (userToUpdate == null)
            {
                return new UserProfileDTO();
            }
            userToUpdate.ModifiedDate = DateTime.Now;
            userToUpdate.IsModified = true;
            var userUpdated = _context.UserProfiles.Update(userToUpdate);
            await _context.SaveChangesAsync();
            return _mapper.Map<UserProfile, UserProfileDTO>(userUpdated.Entity);
        }
    }
}
