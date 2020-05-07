using System;
using System.Collections.Generic;
using System.Text;

namespace Core.IRepository.Base
{
    /// <summary>
    /// 仓储基类
    /// </summary>
    /// <typeparam name="TEntity">实体对象</typeparam>
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        #region 查询
        List<TEntity> Query();
        #endregion
    }
}
