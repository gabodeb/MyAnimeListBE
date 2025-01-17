using Common.Models.Business;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CreateUserRepository : ICreateUserRepository
    {
        public Task<string> CreateUserAsync(CreateUser user) 
        {
            return Task.FromResult("User created");
        }
    }
}
