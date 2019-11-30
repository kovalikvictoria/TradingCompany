using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IDalCrud<TEntity> : IDalRead<TEntity> where TEntity : IEntity
    {
        int Insert(TEntity entity);

        int UpdateByEntity(TEntity entity);
        int UpdateByFieldName(string fieldName, string text, string fieldCondition, string textCondition);

        int DeleteById(int id);
        int DeleteByFieldName(string fieldCondition, string textCondition);
        int Delete(TEntity entity);
    }
}
