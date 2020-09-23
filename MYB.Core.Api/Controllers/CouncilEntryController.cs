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
    [Route("council")]
    [ApiController]
    public class CouncilEntryController : ControllerBase
    {
        private readonly ICouncilService service;



        public CouncilEntryController(ICouncilService service)
        {
            this.service = service;
            //this.contactservice = contactservice;
            //this.attributeservice = attributeservice;
        }

    }


        

        
}
