using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Product.WebApi.Models;
using Test.Product.WebApi.Services;

namespace Test.Product.WebApi.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitesController : ControllerBase
    {
        public SitesController(SiteService siteService)
        {
            SiteService = siteService;
        }

        private SiteService SiteService { get; }

        [HttpGet("{id}")]
        public SiteModel GetById(string id)
        {
            return SiteService.GetById(id);
        }

    }
}
