using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TreeAppAPIv1.Dtos;
using TreeAppAPIv1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeAppAPIv1.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public RegionController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        // GET api/Region
        [HttpGet]
        //[Route("All")]
        public async Task<IActionResult> GetRegions()
        {
            var regions = await uow.RegionRepository.GetRegionsAsync();
            var custDto = mapper.Map<IEnumerable<regionDto>>(regions);
            return Ok(custDto);
        }

        //Region/1
        [HttpGet("{id}")]
        //[AllowAnonymous]
        public async Task<IActionResult> GetRegionById(int id)
        {
            var aregion = await uow.RegionRepository.GetRegionByNoAsync(id);
            return Ok(aregion);
        }

    }
}
