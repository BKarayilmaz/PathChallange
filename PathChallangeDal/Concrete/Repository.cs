using Microsoft.EntityFrameworkCore;
using PathChallange.Dal.Abstract;
using PathChallangeDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathChallange.Dal.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity:class
    {
        protected DbContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(int id)
        {
            _dbSet.Remove(GetById(id));
            _context.SaveChanges();
        }

      

      

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

    }
}
