using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    [Route("template")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly ApplicationContext Context;
        private readonly ILogger<TemplateController> _logger;
        public TemplateController(ILogger<TemplateController> logger, ApplicationContext context )
        {
            _logger = logger;
            this.Context = context;
        }
        

      
        public ActionResult Get(int Id) => new JsonResult(this.Context.Templates.Include(x => x.Questions).Where(x => x.Id == Id).ToList());
        public ActionResult Get() => new JsonResult(this.Context.Templates);
        [HttpPost("SaveTemplate")]
        public async Task<ActionResult> Save([FromBody]Template template)
        {
            this.Context.Templates.Add(template);
            await this.Context.SaveChangesAsync();

            return new JsonResult(template);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Template template)
        {
            this.Context.Templates.Add(template);
            await this.Context.SaveChangesAsync();

            return new JsonResult(template);
        }

    }
}