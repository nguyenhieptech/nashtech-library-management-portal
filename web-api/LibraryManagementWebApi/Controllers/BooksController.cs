﻿using LibraryManagementWebApi.Repositories;
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
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _repository;
        private readonly ILogger<BooksController> _logger;

        public BooksController(IBooksRepository repository, ILogger<BooksController> logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
