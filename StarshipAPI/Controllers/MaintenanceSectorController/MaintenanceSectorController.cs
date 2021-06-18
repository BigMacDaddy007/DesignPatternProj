using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarshipAPI.Models;
using Microsoft.EntityFrameworkCore;
using Shared.PatternsBase.Command.interfaces;

namespace StarshipAPI.Controllers.MaintenanceSectorController
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceSectorController : ControllerBase
    {
        private readonly StarshipContext _context;

        public MaintenanceSectorController(StarshipContext context)
        {
            this._context = context;
        }
    }
}
