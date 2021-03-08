using System.Collections.Generic;
using System.Linq;
using ArticleAPp.API.Data;
using Microsoft.AspNetCore.Mvc;
using ArticleAPp.API.Data;
using ArticleAPp.API.Migrations;
using ArticleAPp.API.Models;

namespace ArticleAPp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController: ControllerBase
    {
        private DataContext _context = null;
        public ArticleController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetArticles()
        {
            return Ok(_context.Articles.ToList());
        }
    }
}