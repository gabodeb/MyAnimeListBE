using Common.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface ICreateUserRepository
    {
        public Task<string> CreateUserAsync(CreateUser user);
    }
}
