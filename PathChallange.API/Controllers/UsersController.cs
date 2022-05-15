using Microsoft.AspNetCore.Mvc;
using PathChallange.Entities.Models;
using PathChallangeDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PathChallange.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private PathChallangeDbContext dbContext;
        public UsersController()
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
            var entity = dbContext.Users.ToList();
            return Ok(entity);//200 + data
        }
        /// <summary>
        /// Create New Data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Users entity)
        {
            if (ModelState.IsValid)
            {
                var createdData = dbContext.Users.Add(entity);
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
            var entity = dbContext.Users.Find(id);
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
            if (dbContext.Users.Find(id) != null)
            {
                dbContext.Users.Remove(dbContext.Users.Find(id));
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
        public IActionResult Update(Users entity)
        {
            if (GetById(entity.UserID) != null)
            {
                dbContext.Users.Update(entity);
                dbContext.SaveChanges();
                return Ok(entity);//200 + data
            }
            return NotFound();
        }
    }
}
