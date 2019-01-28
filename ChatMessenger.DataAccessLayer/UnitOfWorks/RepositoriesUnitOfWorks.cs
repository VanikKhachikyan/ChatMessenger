using ChatMessenger.Core.Interfaces.Repositories;
using ChatMessenger.Core.Interfaces.UnitOfWorks;
using ChatMessenger.DataAccessLayer.Data;
using ChatMessenger.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger.DataAccessLayer.UnitOfWorks
{
    class RepositoriesUnitOfWorks : IRepositoriesUnitOfWork
    {
        protected readonly ChatMessengerDbContext _dbContext;
        protected IUserRepository _userRepository;
        protected IMessageRepository _messageRepository;

        public RepositoriesUnitOfWorks(ChatMessengerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUserRepository Users
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_dbContext);
                }

                return _userRepository;
            }
        }

        public IMessageRepository Messages
        {
            get
            {
                if (_messageRepository == null)
                {
                    _messageRepository = new MessageRepository(_dbContext);
                }

                return _messageRepository;
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public virtual async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
