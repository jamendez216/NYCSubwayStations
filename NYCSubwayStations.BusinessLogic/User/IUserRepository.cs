using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.BusinessLogic.User
{
    public interface IUserRepository
    {
        Task AddUserAsync(Models.Models.User user);
        Task<bool> EMailExists(string email);
        Task<Models.Models.User> GetUserFromCredentials(string email, string password);
        Task<bool> UsernameExists(string username);
    }
}
