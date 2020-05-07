using System;
using System.Collections.Generic;
using System.Text;

namespace Core.IServices.Base
{
    public interface IBaseServices<TEntity>  where TEntity : class
    {
        #region 查询
        List<TEntity> Query();
        #endregion
    }
}
