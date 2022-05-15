using Microsoft.AspNetCore.Mvc;
using PathChallange.Entities.Models;
using PathChallangeDal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PathChallange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private PathChallangeDbContext dbContext;
        public OrdersController()
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
            var entity = dbContext.Orders.ToList();
            return Ok(entity);//200 + data
        }
        /// <summary>
        /// Create New Data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Orders entity)
        {
            if (ModelState.IsValid)
            {
                string randomName = Path.GetRandomFileName().Replace(".","");
                entity.OrderID=randomName;
                var createdData = dbContext.Orders.Add(entity);
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
            var entity = dbContext.Orders.Find(id);
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
            if (dbContext.Orders.Find(id) != null)
            {
                dbContext.Orders.Remove(dbContext.Orders.Find(id));
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
        public IActionResult Update(Orders entity)
        {
            if (dbContext.Orders.Find(entity.OrderID) != null)
            {
                dbContext.Orders.Update(entity);
                dbContext.SaveChanges();
                return Ok(entity);//200 + data
            }
            return NotFound();
        }
    }
}
