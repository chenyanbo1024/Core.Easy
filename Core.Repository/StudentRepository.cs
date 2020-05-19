using Core.IRepository;
using Core.Model;
using Core.Model.EFDbContext;
using Core.Repository.Base;

namespace Core.Repository
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public CoreContext _context { get; }

        public StudentRepository(CoreContext context)
            : base(context)
        {
            _context = context;
        }
    }
}