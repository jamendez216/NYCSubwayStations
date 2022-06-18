using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NYCSubwayStations.BusinessLogic.User
{
    public interface IUserRepository
    {
        public Task AddUserAsync(Models.Models.User user);
        public Task<bool> EMailExists(string email);
    }
}
