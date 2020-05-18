using Core.IRepository;
using Core.IServices;
using Core.Model;
using Core.Services.Base;

namespace Core.Services
{
    public class ClassesServices : BaseServices<Classes>, IClassesServices
    {
        public IClassesRepository _dal;

        public ClassesServices(IClassesRepository dal)
        {
            _dal = dal;
            base.baseDal = _dal;
        }
    }
}