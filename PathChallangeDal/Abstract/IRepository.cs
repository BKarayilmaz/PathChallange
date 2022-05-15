using System;
using System.Collections.Generic;
using System.Text;

namespace PathChallange.Dal.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(int id);
    }
}
