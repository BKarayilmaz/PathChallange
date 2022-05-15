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
    public class AuthorityController : Controller
    {
        private PathChallangeDbContext dbContext;
        public AuthorityController()
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
            var entity = dbContext.Authorities.ToList();
            return Ok(entity);//200 + data
        }
        /// <summary>
        /// Create New Data
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(Authority entity)
        {
            if (ModelState.IsValid)
            {
                var createdData = dbContext.Authorities.Add(entity);
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
            var entity = dbContext.Authorities.Find(id);
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
            if (dbContext.Authorities.Find(id) != null)
            {
                dbContext.Authorities.Remove(dbContext.Authorities.Find(id));
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
        public IActionResult Update(Authority entity)
        {
            if (GetById(entity.AuthorityID) != null)
            {
                dbContext.Authorities.Update(entity);
                dbContext.SaveChanges();
                return Ok(entity);//200 + data
            }
            return NotFound();
        }
    }
}
