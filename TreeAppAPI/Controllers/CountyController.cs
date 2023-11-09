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
    public class CountyController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public CountyController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        // GET api/County
        [HttpGet]
        //[Route("All")]
        public async Task<IActionResult> GetCounty()
        {
            var county = await uow.CountyRepository.GetCountyAsync();
            var custDto = mapper.Map<IEnumerable<countyDto>>(county);
            return Ok(custDto);
        }

        //County/1
        [HttpGet("{id}")]
        //[AllowAnonymous]
        public async Task<IActionResult> GetCountyById(int id)
        {
            var acounty = await uow.CountyRepository.GetCountyByNoAsync(id);
            return Ok(acounty);
        }

    }
}
