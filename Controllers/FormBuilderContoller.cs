using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication11.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication11.Controllers
{
    [Route("Formbuilder")]
    public class FormBuilderContoller : ControllerBase
    {
        // GET: api/<controller>
        ApplicationContext Context;
        public FormBuilderContoller(ApplicationContext context)
        {
            this.Context = context;
        }

        [HttpGet("Get")]
        public ActionResult Get(int Id) => new JsonResult(this.Context.Templates.Include(x => x.Questions).Where(x => x.Id == Id).ToList());

        [HttpGet("Get")]
        public ActionResult Get() => new JsonResult(this.Context.Templates);
        // GET api/<controller>/5
     

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Template template)
        {
            this.Context.Templates.Add(template);
           await  this.Context.SaveChangesAsync();

            return new JsonResult("Added");
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
