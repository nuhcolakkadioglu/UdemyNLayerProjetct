using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayerProjetct.Core.Models;
using UdemyNLayerProjetct.Core.Services;

namespace UdemyNLayerProjetct.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Person> _personService;
        public PersonsController(IService<Person> service, IMapper mapper)
        {
            _personService = service;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _personService.GetAllAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Save(Person person)
        {

            return Ok(await _personService.AddAsync(person));
        }
    }
}
