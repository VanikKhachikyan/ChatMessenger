using ChatMessenger.Core.Interfaces.Repositories;
using ChatMessenger.Core.Models.Db;
using ChatMessenger.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ChatMessenger.DataAccessLayer.Repositories
{
    internal class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ChatMessengerDbContext dbContex)
            : base(dbContex)
        {

        }

        public virtual async Task<bool> CheckingEmailExists(string email)
        {
            return await _dbSet.Where(wc => wc.Email.ToUpper() == email.ToUpper()).AnyAsync();
        }

        public virtual async Task<User> GetUserByEmailAndPassword(string email, string password)
        {
            return await _dbSet.Where(wc => wc.Email.ToUpper() == email.ToUpper() &&
                                      wc.Password == password &&
                                      !wc.Deleted).FirstOrDefaultAsync();
        }

    }
}
