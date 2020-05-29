using Core.IRepository;
using Core.Model.EFDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        public CoreContext _context { get; }
        public DbSet<TEntity> _dbset;

        public BaseRepository(CoreContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }

        #region 增

        public bool Insert(TEntity entity, bool isSaveChange)
        {
            _dbset.Add(entity);
            if (isSaveChange)
            {
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool Insert(List<TEntity> entities, bool isSaveChange = true)
        {
            _dbset.AddRange(entities);
            if (isSaveChange)
            {
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        #endregion 增

        #region 删

        public bool Delete(TEntity entity, bool isSaveChange = true)
        {
            _dbset.Attach(entity);      //使 实体 被 dbcontext 追踪到
            _dbset.Remove(entity);
            if (isSaveChange)
            {
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(List<TEntity> entitys, bool isSaveChange = true)
        {
            _dbset.AttachRange(entitys);      //使 实体 被 dbcontext 追踪到
            _dbset.RemoveRange(entitys);
            if (isSaveChange)
            {
                _context.SaveChanges();
            }
            return false;
        }

        public bool Delete(Expression<Func<TEntity, bool>> predicate, bool isSaveChange = true)
        {
            var list = GetList(predicate);
            if (list.Count <= 0)
            {
                return false;
            }

            _dbset.RemoveRange(list);
            if (isSaveChange)
            {
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool Delete(object id, bool isSaveChange = true)
        {
            var data = Find(id);
            if (data == null)
            {
                return false;
            }

            _dbset.Remove(data);
            if (isSaveChange)
            {
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        #endregion 删

        #region 改

        public bool Update(TEntity entity, bool isSaveChange = true, List<string> updatePropertyList = null)
        {
            if (entity == null)
            {
                return false;
            }
            _dbset.Attach(entity);
            var entry = _context.Entry(entity);
            if (updatePropertyList == null)
            {
                entry.State = EntityState.Modified;         //全字段更新
            }
            else
            {
                updatePropertyList.ForEach(c =>
                {
                    entry.Property(c).IsModified = true;    //部分字段更新的写法
                });
            }
            if (isSaveChange)
            {
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        public bool Update(List<TEntity> entitys, bool isSaveChange = true, List<string> updatePropertyList = null)
        {
            if (entitys == null)
            {
                return false;
            }
            _dbset.AttachRange(entitys);
            var entry = _context.Entry(entitys);
            if (updatePropertyList == null)
            {
                entry.State = EntityState.Modified;             //全字段更新
            }
            else
            {
                updatePropertyList.ForEach(c =>
                {
                    entry.Property(c).IsModified = true;        //部分字段更新
                });
            }
            if (isSaveChange)
            {
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        #endregion 改

        #region 查

        public long Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate == null)
            {
                predicate = c => true;
            }
            return _dbset.LongCount(predicate);
        }

        public TEntity Find(object id)
        {
            return _dbset.Find(id);
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> predicate, string orderby = "", bool isNoTracking = true)
        {
            var data = isNoTracking ? _dbset.Where(predicate).AsNoTracking() : _dbset.Where(predicate);
            if (data.Count() <= 0)
            {
                return default;
            }
            return data.ToList();
        }

        public TEntity Single(Expression<Func<TEntity, bool>> predicate)
        {
            TEntity entity = _dbset.Single(predicate);
            if (entity == null)
            {
                entity = new TEntity();
            }
            return entity;
        }

        #endregion 查

        #region 执行SQL语句

        public void BulkInsert<T>(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlRaw(string sql, params object[] para)
        {
            return _context.Database.ExecuteSqlRaw(sql, para);
        }

        public List<TEntity> FromSqlRaw(string sql, params object[] para)
        {
            return _dbset.FromSqlRaw(sql, para).ToList();
        }

        #endregion 执行SQL语句
    }
}