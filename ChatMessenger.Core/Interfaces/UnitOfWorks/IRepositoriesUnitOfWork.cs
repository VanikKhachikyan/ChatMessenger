﻿using ChatMessenger.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger.Core.Interfaces.UnitOfWorks
{
    public interface IRepositoriesUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IMessageRepository Messages { get; }

        Task<int> SaveAsync();
    }
}
