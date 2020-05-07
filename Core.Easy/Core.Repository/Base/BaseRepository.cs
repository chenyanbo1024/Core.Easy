using Core.IRepository.Base;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Core.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly CoreContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(CoreContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }



        public List<TEntity> Query()
        {
            return _dbSet.ToList();
        }

    }
}
