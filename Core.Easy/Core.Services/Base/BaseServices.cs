using Core.IRepository.Base;
using Core.IServices.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Base
{
    public class BaseServices<TEntity> : IBaseServices<TEntity> where TEntity : class
    {
        public IBaseRepository<TEntity> BaseDal;

        public List<TEntity> Query()
        {
            return BaseDal.Query();
        }
    }
}
