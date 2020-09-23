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
   
    [ApiController]
    public class OfficersController : ControllerBase
    {
        private readonly IOfficerService service;

        public OfficersController(IOfficerService service)
        {
            this.service = service;
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of officers for a particular council. Officer function retunred reagrdless of whether it is curretnly being fullfilled by a person
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/council/{id}/officers")]
        public async Task<IEnumerable<OfficerDTO>>Get(int id)
        {
            var officers = await service.Read(1, id);

            return officers;
        }



        // GET api/documentation
        /// <summary>
        /// Get an officer record. An officer may fullfill more than one officer function or be employed by more that one coucil
        ///  /// <param name="personId">the personID value found in the officer endpoint</param>
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/council/officer/{personId}")]
        public async Task<ActionResult<PersonEntryDTO>> GetPersonDTO(int personId)
        {
            var personDTO = await service.Read(personId);

            if (personDTO == null)
            {
                return NotFound();
            }

            return personDTO;
        }


    }
}
