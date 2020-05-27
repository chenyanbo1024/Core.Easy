using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.IRepository.Base
{
    /// <summary>
    /// 仓储基类
    /// </summary>
    /// <typeparam name="TEntity">数据传输对象</typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        #region 增

        bool Insert(TEntity entity, bool isSaveChange = true);

        bool Insert(List<TEntity> entities, bool isSaveChange = true);

        #endregion 增

        #region 删(删除前需要查询)

        bool Delete(TEntity entity, bool isSaveChange = true);

        bool Delete(List<TEntity> entitys, bool isSaveChange = true);

        bool Delete(Expression<Func<TEntity, bool>> predicate, bool isSaveChange = true);

        bool Delete(object id, bool isSaveChange = true);

        #endregion 删(删除前需要查询)

        #region 改

        bool Update(TEntity entity, bool isSaveChange = true, List<string> updatePropertyList = null);

        bool Update(List<TEntity> entitys, bool isSaveChange = true, List<string> updatePropertyList = null);

        #endregion 改

        #region 查

        long Count(Expression<Func<TEntity, bool>> predicate = null);

        TEntity Find(object id);

        List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate, string orderby, bool isNoTracking);

        TEntity Single(Expression<Func<TEntity, bool>> predicate);

        #endregion 查

        #region 执行SQL语句

        void BulkInsert<T>(List<T> entities);

        int ExecuteSqlRaw(string sql, params object[] para);

        List<TEntity> FromSqlRaw(string sql, params object[] para);

        #endregion 执行SQL语句
    }
}