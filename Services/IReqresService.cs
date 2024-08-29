using ConsumeApiExample.DTO;

namespace ConsumeApiExample.Services
{
    public interface IReqresService
    {
        Task<UserDTO> GetUserByIdAysnc(int id);
        Task<UsersDTO> GetUsers();
    }
}
