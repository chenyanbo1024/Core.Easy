namespace Core.IServices.Base
{
    public interface IBaseServices<TEntity> where TEntity : class
    {
        bool Insert(TEntity entity, bool isSaveChange = true);
    }
}