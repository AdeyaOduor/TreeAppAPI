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
    public class SubCountyController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        private readonly IMapper mapper;

        public SubCountyController(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            this.mapper = mapper;
        }
        // GET api/SubCounty
        [HttpGet]
        //[Route("All")]
        public async Task<IActionResult> GetSubCounty()
        {
            var subcounty = await uow.SubCountyRepository.GetSubCountyAsync();
            var custDto = mapper.Map<IEnumerable<subcountyDto>>(subcounty);
            return Ok(custDto);
        }

        //SubCounty/1
        [HttpGet("{id}")]
        //[AllowAnonymous]
        public async Task<IActionResult> GetSubCountyById(int id)
        {
            var acounty = await uow.SubCountyRepository.GetSubCountyByNoAsync(id);
            return Ok(asubcounty);
        }

    }
}
