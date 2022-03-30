using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SrDashboard_SR.DataTransferObject;
using SrDashboard_SR.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SrDashboard_SR.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ConsultantController : ControllerBase
    {
        private readonly IConsultantService _consultantService;
        private readonly IMapper _mapper;

        public ConsultantController(IConsultantService consultantService, IMapper mapper)
        {
            _consultantService = consultantService;
            _mapper = mapper;
        }

        //Get list of consultants
        [HttpGet]
        [ProducesResponseType(typeof(List<ConsultantResponseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetConsultants()
        {
            var consultants = _consultantService.GetConsultants();
            if (!consultants.Any())
            {
                return NoContent();
            }
            var result = _mapper.Map<List<ConsultantResponseDto>>(consultants);
            return Ok(result);
        }

        ///Get a Consultant
        ///<param name="consultantId"></param>
        [HttpGet("{consultantId}")]
        [ProducesResponseType(typeof(ConsultantResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetConsultant([FromRoute] int consultantId)
        {
            var consultants = _consultantService.GetConsultant(consultantId);
            if (consultants == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<ConsultantResponseDto>(consultants);
            return Ok(result);
        }
    }
}
