using PM_Models.UserProfilesModels;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface IUserTypeRepo
    {
        public Task<UserTypeDTO> CreateUserType(UserTypeDTO userType);
        public Task<UserTypeDTO> GetUserType(int id);
        public Task<IEnumerable<UserTypeDTO>> GetUserTypes();
        public Task<UserTypeDTO> UpdateUserType(UserTypeDTO userType);
        public Task<UserTypeDTO> DeleteUserType(int id);
    }
}
