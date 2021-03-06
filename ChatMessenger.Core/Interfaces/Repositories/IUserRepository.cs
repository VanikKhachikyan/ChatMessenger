﻿using ChatMessenger.Core.Models.Db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger.Core.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<bool> CheckingEmailExists(string email);
        Task<User> GetUserByEmailAndPassword(string email, string password);
    }
}
