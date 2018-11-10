using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptestcloud.Controllers
{
    public class ArticlesController : Controller
    {
        [HttpGet("api/articles")]
        public JsonResult GetArticles()
        {
            return new JsonResult(ArticlesDataStore.Current.Articles);

        }
    }
}
