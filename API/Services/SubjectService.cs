using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class SubjectService
    {
        private readonly DbSksContext _db = new DbSksContext();

        public async Task createSubject(Subject subject)
        {
            await _db.Subjects.AddAsync(subject);
            await _db.SaveChangesAsync();
        }
        public async Task<List<Subject>> getAllSubjects()
        {
            return await _db.Subjects
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Subject?> getSubject(string name)
        {
            return _db.Subjects
                .AsNoTracking()
                .FirstOrDefault(s => s.Name == name);
        }

        public async Task updateSubject(Subject subject)
        {
            await _db.Subjects
                .Where(s => s.Name == subject.Name)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(s => s.Description, subject.Description)
                    .SetProperty(s => s.Cabinet, subject.Cabinet)
                    .SetProperty(s => s.UserLogin, subject.UserLogin));
        }

        public async Task deleteSubject(Subject subject)
        {
            await _db.Subjects
                .Where(s => s.Name == subject.Name)
                .ExecuteDeleteAsync();
        }
    }
}
