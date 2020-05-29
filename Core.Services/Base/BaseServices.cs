using Core.IRepository;
using Core.IServices.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Services.Base
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class
    {
        public IBaseRepository<TEntity> baseDal;

        #region 增

        /// <summary>
        /// 新增单条数据
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSaveChange">是否保存修改</param>
        /// <returns></returns>
        public bool Insert(TEntity entity, bool isSaveChange = true)
        {
            return baseDal.Insert(entity, isSaveChange);
        }

        /// <summary>
        /// 新增多条数据
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="isSaveChange">是否保存修改</param>
        /// <returns></returns>
        public bool Insert(List<TEntity> entities, bool isSaveChange = true)
        {
            return baseDal.Insert(entities, isSaveChange);
        }

        #endregion 增

        #region 删

        /// <summary>
        /// 删除单条数据
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSaveChange">是否保存修改</param>
        /// <returns></returns>
        public bool Delete(TEntity entity, bool isSaveChange = true)
        {
            return baseDal.Delete(entity, isSaveChange);
        }

        /// <summary>
        /// 删除多条数据
        /// </summary>
        /// <param name="entitys"></param>
        /// <param name="isSaveChange">是否保存修改</param>
        /// <returns></returns>
        public bool Delete(List<TEntity> entitys, bool isSaveChange = true)
        {
            return baseDal.Delete(entitys, isSaveChange);
        }

        #endregion 删

        #region 改

        public bool Update(TEntity entity, bool isSaveChange = true, List<string> updatePropertyList = null)
        {
            return baseDal.Update(entity, isSaveChange, updatePropertyList);
        }

        public bool Update(List<TEntity> entitys, bool isSaveChange = true, List<string> updatePropertyList = null)
        {
            return baseDal.Update(entitys, isSaveChange, updatePropertyList);
        }

        #endregion 改

        #region 查

        public long Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            return baseDal.Count(predicate);
        }

        public TEntity Find(object id)
        {
            return baseDal.Find(id);
        }

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            return baseDal.Single(predicate);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate, string orderby = "", bool isNoTracking = true)
        {
            return baseDal.GetList(predicate, orderby, isNoTracking);
        }

        #endregion 查

        #region 执行SQL语句

        public void BulkInsert<T>(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlRaw(string sql, params object[] para)
        {
            return baseDal.ExecuteSqlRaw(sql, para);
        }

        public List<TEntity> FromSqlRaw(string sql, params object[] para)
        {
            return baseDal.FromSqlRaw(sql, para);
        }

        #endregion 执行SQL语句
    }
}