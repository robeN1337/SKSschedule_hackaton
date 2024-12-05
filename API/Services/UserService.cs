using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class UserService
    {
        private readonly DbSksContext _db = new DbSksContext();

        public async Task createUser(User user)
        {
            await _db.Users.AddAsync(user);    
            await _db.SaveChangesAsync();
        }

        public async Task<List<User>> getAllUsers()
        {
            return await _db.Users
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<User?> getUserByLogin(string login)
        {
            return _db.Users
                .AsNoTracking()
                .FirstOrDefault(u => u.Login == login);
        }

        public async Task updateUser(User user)
        {
            await _db.Users
                .Where(u => u.Login == user.Login)
                .ExecuteUpdateAsync(u => u
                    .SetProperty(u => u.Password, user.Password)
                    .SetProperty(u => u.Fio, user.Fio)
                    .SetProperty(u => u.Birthday, user.Birthday)
                    .SetProperty(u => u.GroupId, user.GroupId)
                    .SetProperty(u => u.RoleId, user.RoleId));
        }

        public async Task deleteUser(User user)
        {
            await _db.Users
                .Where(u => u.Login == user.Login)
                .ExecuteDeleteAsync();
        }
    }
}
