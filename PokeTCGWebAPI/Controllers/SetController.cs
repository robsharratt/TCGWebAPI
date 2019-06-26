﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokeTCGWebAPI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokeTCGWebAPI.Controllers
{
    public class SetController : Controller
    {
        private ISetRepository repository;
        public SetController(ISetRepository repo)
        {
            repository = repo;
        }
    }
}
