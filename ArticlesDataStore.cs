using asptestcloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asptestcloud
{
    public class ArticlesDataStore
    {
        public static ArticlesDataStore Current { get; } = new ArticlesDataStore();
        public List<ArticlesDto> Articles { get; set; }

        public ArticlesDataStore()
        {
            Articles = new List<ArticlesDto>()
            {
                new ArticlesDto()
                {
                    Id = 1,
                    Name = "First Normal C#",
                    Description = "The First Article",
                    Date = DateTime.Now.AddDays(-3)
                },
                new ArticlesDto()
                {
                    Id = 2,
                    Name = "How to build ASP",
                    Description = "The Second Article",
                    Date = DateTime.Now
                }
            };
        }
    }
}
