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
    public class LookUpController : ControllerBase
    {
        private readonly ILookUpService service;

        public LookUpController(ILookUpService service)
        {
            this.service = service;
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of  officer functions
        /// </summary>
        /// <returns></returns>
        [HttpGet("officersfunctions/")]
        public async Task<IEnumerable<LookupDTO>> GetOfficerFunctions()
        {
            return await service.OfficerFunctions();
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of  councillor function
        /// </summary>
        /// <returns></returns>
        [HttpGet("councillorfunctions/")]
        public async Task<IEnumerable<LookupDTO>> GetCouncillorFunctions()
        {
            return await service.CouncillorFunctions();
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of  councillor function
        /// </summary>
        /// <returns></returns>
        [HttpGet("officerStatus/")]
        public async Task<IEnumerable<LookupDTO>>GetOfficerStatus()
        {
            return await service.Status();
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of  person salutation
        /// </summary>
        /// <returns></returns>
        [HttpGet("salutations/")]
        public async Task<IEnumerable<LookupDTO>> GetTitles()
        {
            return await service.Titles();
        }


        // GET api/documentation
        /// <summary>
        /// Get a list of  person  genders
        /// </summary>
        /// <returns></returns>
        [HttpGet("gender/")]
        public string [] GetGender()
        {
            return service.Gender();
        }


        // GET api/documentation
        /// <summary>
        /// Get a list of  council countries       
        ///summary>
        /// <returns></returns>
        [HttpGet("countries/")]
        public string [] GetCountries()
        {
            return  service.Countries();
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of political parties
        /// </summary>
        /// <returns></returns>
        [HttpGet("politicalparties/")]
        public async Task<IEnumerable<LookupDTO>> GetParties()
        {
            return await service.Parties();
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of council committes
        /// </summary>
        /// <returns></returns>
        [HttpGet("committees/")]
        public async Task<IEnumerable<LookupDTO>> GetCommittees()
        {
            return await service.Committees();
        }
    }
      
}
