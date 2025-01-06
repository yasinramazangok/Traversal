using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalApi.DAL.Context;
using TraversalApi.DAL.Entities;

namespace TraversalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VisitorController : ControllerBase
    {
        [HttpGet]
        public IActionResult VisitorList()
        {
            using (var context = new TraversalApiContext())
            {
                var values = context.Visitors.ToList();
                return Ok(values);
            }
        }

        [HttpPost]
        public IActionResult AddVisitor(Visitor visitor)
        {
            using (var context = new TraversalApiContext())
            {
                context.Add(visitor);
                context.SaveChanges();
                return Ok();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetVisitorById(int id)
        {
            using (var context = new TraversalApiContext())
            {
                var values = context.Visitors.Find(id);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(values);
                }
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVisitor(int id)
        {
            using (var context = new TraversalApiContext())
            {
                var values = context.Visitors.Find(id);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    context.Remove(values);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }

        [HttpPut]
        public IActionResult UpdateVisitor(Visitor visitor)
        {
            using (var context = new TraversalApiContext())
            {
                var values = context.Find<Visitor>(visitor.VisitorId);
                if (values == null)
                {
                    return NotFound();
                }
                else
                {
                    values.Name = visitor.Name;
                    values.Surname = visitor.Surname;
                    values.Email = visitor.Email;
                    values.City = visitor.City;
                    values.Country = visitor.Country;
                    context.Update(values);
                    context.SaveChanges();
                    return Ok();
                }
            }
        }

    }
}
