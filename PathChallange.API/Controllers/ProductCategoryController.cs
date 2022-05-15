using Microsoft.AspNetCore.Mvc;
using PathChallange.Entities;
using PathChallangeDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathChallange.API.Controllers
{
    public class ProductCategoryController : Controller
    {
        private PathChallangeDbContext dbContext;
        public ProductCategoryController()
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
            var entity = dbContext.ProductCategories.ToList();
            return Ok(entity);//200 + data
        }
        /// <summary>
        /// Create New Data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(ProductCategory entity)
        {
            if (ModelState.IsValid)
            {
                var createdData = dbContext.ProductCategories.Add(entity);
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
            var entity = dbContext.ProductCategories.Find(id);
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
            if (dbContext.ProductCategories.Find(id) != null)
            {
                dbContext.ProductCategories.Remove(dbContext.ProductCategories.Find(id));
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
        public IActionResult Update(ProductCategory entity)
        {
            if (GetById(entity.CategoryID) != null)
            {
                dbContext.ProductCategories.Update(entity);
                dbContext.SaveChanges();
                return Ok(entity);//200 + data
            }
            return NotFound();
        }
    }
}
