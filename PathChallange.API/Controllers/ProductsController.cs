using Microsoft.AspNetCore.Mvc;
using PathChallange.Dal.Abstract;
using PathChallange.Entities;
using PathChallange.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PathChallangeDal;

namespace PathChallange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private PathChallangeDbContext dbContext;
        public ProductsController()
        {
            dbContext = new PathChallangeDbContext();
        }
        /// <summary>
        /// Get All Data
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var entity= dbContext.Products.ToList();
            return Ok(entity);//200 + data
        }
        /// <summary>
        /// Create New Data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Products entity)
        {
            if (ModelState.IsValid)
            {
                var createdData=dbContext.Products.Add(entity);
                dbContext.SaveChanges();
                return Ok(entity);//200 + data
            }
            
            return BadRequest(ModelState);//400 + validation errors
        }
        /// <summary>
        /// Get Data By ID
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity= dbContext.Products.Find(id);
            if (entity != null)
            {
                return Ok(entity);//200 + data
            }
            return NotFound();//404
        }
        /// <summary>
        /// Remove Data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
       [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            if (dbContext.Products.Find(id) != null)
            {
                dbContext.Products.Remove(dbContext.Products.Find(id));
                dbContext.SaveChanges();
                return Ok();
            }
            return NotFound();
        }
        /// <summary>
        /// Update Data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(Products entity)
        {
            if (GetById(entity.ProductID) != null)
            {
                dbContext.Products.Update(entity);
                dbContext.SaveChanges();
                return Ok(entity);//200 + data
            }
            return NotFound();
        }
    }
}
