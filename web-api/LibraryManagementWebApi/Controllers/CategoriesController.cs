using LibraryManagementWebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesRepository _repository;
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ICategoriesRepository repository, ILogger<CategoriesController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
