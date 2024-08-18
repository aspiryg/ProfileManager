using PM_Models.UserProfilesModels;

namespace PM_Server.Business.Repositories.IRepo
{
    public interface IUserProfileRepo
    {
        public Task<UserProfileDTO> CreateUserProfile(UserProfileDTO user);
        public Task<UserProfileDTO> UpdateUserProfile(UserProfileDTO user);
        public Task<UserProfileDTO> GetUserProfile(int userID);
        public Task<UserProfileDTO> GetUserProfileByCode(Guid userCode);
        public Task<IEnumerable<UserProfileDTO>> GetAllUserProfiles();
        public Task<UserProfileDTO> DeleteUserProfile(int userID);
        // Search for users by name
        public Task<IEnumerable<UserProfileDTO>> SearchUserProfiles(string name);
        // Remove User from the system
        public Task<int> RemoveUser(int userID);

        // Get User by Email
        public Task<UserProfileDTO> GetUserByEmail(string email);

        // Get User by Role
        public Task<IEnumerable<UserProfileDTO>> GetUserByRole(string role);
        public Task<IEnumerable<UserProfileDTO>> GetUserByType(string type);

        // Get all user types
        public Task<IEnumerable<UserTypeDTO>> GetUserTypes();
    }
}
