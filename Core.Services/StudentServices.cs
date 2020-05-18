using Core.IRepository;
using Core.IServices;
using Core.Model;
using Core.Services.Base;

namespace Core.Services
{
    public class StudentServices : BaseServices<Student>, IStudentServices
    {
        public IStudentRepository _dal;

        public StudentServices(IStudentRepository dal)
        {
            _dal = dal;
            base.baseDal = _dal;
        }
    }
}