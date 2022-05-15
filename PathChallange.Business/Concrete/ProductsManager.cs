using PathChallange.Business.Abstract;
using PathChallange.Dal.Abstract;
using PathChallange.Dal.Concrete;
using PathChallange.Entities;
using PathChallangeDal;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathChallange.Business.Concrete
{
    class ProductsManager : IProductsService
    {
        // private IRepository<Products> _repository;
        PathChallangeDbContext dbContext;
        private IRepository<PathChallangeDbContext> _repository;
        public ProductsManager()
        {
            //_repository = new Repository<Products>();
        }
        public void Add(Products entity)
        {
            //_repository.Prod.Add(entity);
        }

        public List<Products> GetAll()
        {
            throw new NotImplementedException();
        }

        public Products GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Products entity)
        {
            throw new NotImplementedException();
        }
    }
}
