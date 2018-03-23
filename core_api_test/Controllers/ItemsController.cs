using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_api_test.Models;
using Microsoft.AspNetCore.Mvc;

namespace core_api_test.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : BaseController
    {
        public ItemsController(Entities entities) : base(entities)
        {
        }

        // GET api/values
        [HttpGet]
        public List<Items> Get()
        {
            return _entities.Items.ToList();
        }

        
    }
}
