using PathChallange.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathChallange.Business.Abstract
{
    public interface IProductsService
    {
        List<Products> GetAll();
        Products GetById(int id);
        void Add(Products entity);
        void Update(Products entity);
        void Remove(int id);
    }
}
