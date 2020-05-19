using Core.IRepository;
using Core.Model;
using Core.Model.EFDbContext;
using Core.Repository.Base;

namespace Core.Repository
{
    public class ClassesRepository : BaseRepository<Classes>, IClassesRepository
    {
        public CoreContext _context { get; }

        public ClassesRepository(CoreContext context)
            : base(context)
        {
            _context = context;
        }
    }
}