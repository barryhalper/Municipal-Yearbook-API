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
    //[Route("api/[controller]")]
    [ApiController]
    public class CouncillorController : ControllerBase
    {
        private readonly ICouncillorService service;

        public CouncillorController(ICouncillorService service)
        {
            this.service = service;
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of councillors for a specific council
        /// <param name="id">The Id found in the council endpoint</param>
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/council/{id}/councillors/")]
        public async Task<ActionResult<IEnumerable<CouncillorDTO>>> GetCouncillorsDTO(int id)
        {
            return Ok(await service.Read(id));
        }

        // GET api/documentation
        /// <summary>
        /// Get details of a specific councillor . A councillor is person, who is a member of party for a specific ward. They may aslo be member of Cabinet and fullfill a function in one or many committees
        /// <param name="personId">The person Id found in the councillor endpoint</param>
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/council/councillor/{personId}")]
        public async Task<ActionResult<CouncillorEntryDTO>> GetCouncillorEntryDTO(int personId)
        {
            return Ok(await service.ReadEntry(personId));
        }


    }
}
