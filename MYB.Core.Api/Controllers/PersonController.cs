using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.Business;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;

namespace MYB.Core.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService service;

        public PersonController(IPersonService service)
        {
            this.service = service;
        }



        //GET api/documentation
        /// <summary>
        /// Get a person record.A person may fullfill more than one officer function or be employed by more that one coucil
        /// </summary>
        /// <returns></returns>
        //[HttpGet("{id}")]
        //public async Task<ActionResult<PersonEntryDTO>> GetPersonDTO(int id)
        //{
        //    var personDTO = await service.Read(id);

        //    if (personDTO == null)
        //    {
        //        return NotFound();
        //    }

        //    return personDTO;
        //}


    }
}
