using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYB.Core.Api.Business;
using MYB.Core.Api.DTO;
using MYB.Core.Api.Models;

namespace MYB.Core.Api.Controllers
{
   
    [ApiController]
    
    public class CouncilController : ControllerBase
    {
        private readonly ICouncilService service;
     


        public CouncilController( ICouncilService service)
        {
            this.service = service;
           
        }

        // GET api/documentation
        /// <summary>
        /// Get a list of available council types(local authorities)
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/councils")]
        public async Task<IEnumerable<CouncilDTO>> GetCouncilDTO()
        {
            return await service.Read();
        }


        // GET api/documentation
        /// <summary>
        /// Get a the council entry for a specific council   
        /// <param name="id"></param>
        /// </summary>
        /// <returns></returns>
        ///<response code="404">If the entry is not found</response>
        [HttpGet("api/council/{id}")]
        public async Task<ActionResult<CouncilEntryDTO>> GetCouncilEntryDTO(int id)
        {
            try
            {
                var dto = await service.Read(id);

                if (dto == null)
                {
                    return NotFound();
                }

                return dto;
            }
            catch
            {
                return NotFound();
            }


        }

        // GET api/documentation
        /// <summary>
        /// Get the constiuencies for a specific council   
        /// <param name="id"></param>
        /// </summary>
        /// <returns></returns>
        ///<response code="404">If the entry is not found</response>
        [HttpGet("api/council{id}/constituencies")]
        public async Task<ActionResult<IEnumerable<LookupDTO>>> GetConsituencies(int id)
        {
            try
            {
                var dto = await service.Constiuencies(id);

                if (dto == null)
                {
                    return NotFound();
                }

                return Ok(dto);
            }
            catch
            {
                return NotFound();
            }


        }

        // GET api/documentation
        /// <summary>
        /// Get the constiuencies for a specific council   
        /// <param name="id"></param>
        /// </summary>
        /// <returns></returns>
        ///<response code="404">If the entry is not found</response>
        [HttpGet("api/council{id}/committees")]
        public async Task<ActionResult<IEnumerable<LookupDTO>>> GetCommittees(int id)
        {
            try
            {
                var dto = await service.Constiuencies(id);

                if (dto == null)
                {
                    return NotFound();
                }

                return Ok(dto);
            }
            catch
            {
                return NotFound();
            }


        }
    }




}

