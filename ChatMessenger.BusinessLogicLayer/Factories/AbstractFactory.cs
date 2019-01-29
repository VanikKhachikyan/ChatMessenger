using AutoMapper;
using ChatMessenger.BusinessLogicLayer.BusinessLogics;
using ChatMessenger.Core.Interfaces.BusinessLogics;
using ChatMessenger.Core.Interfaces.UnitOfWorks;
using ChatMessenger.DataAccessLayer.Data;
using ChatMessenger.DataAccessLayer.UnitOfWorks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatMessenger.BusinessLogicLayer.Factories
{
    public abstract class AbstractFactory : IDisposable
    {
        protected readonly IRepositoriesUnitOfWork _repos;
        protected readonly IMapper _mapper;
        protected readonly ChatMessengerDbContext _dbContext;

        public AbstractFactory(ChatMessengerDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _repos = new RepositoriesUnitOfWorks(dbContext);
            _mapper = mapper;
        }

        public abstract IAccountBL CreateAccountBL(IMemoryCache memoryCache, IConfiguration configuration);
        public abstract MessageBL CreateMessageBL();

        public virtual void Dispose()
        {
            _repos.Dispose();
        }
    }
}
