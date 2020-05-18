using Core.IServices.Base;

namespace Core.Services.Base
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class
    {
        public IBaseRepository<TEntity> baseDal;

        public bool Insert(TEntity entity, bool isSaveChange)
        {
            return baseDal.Insert(entity, isSaveChange);
        }
    }
}