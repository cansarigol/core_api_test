using core_api_test.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_api_test.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly Entities _entities;
        
        public BaseController(Entities entities)
        {
            _entities = entities;
        }

        
    }
}
