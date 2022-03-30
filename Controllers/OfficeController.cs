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
    public class OfficeController : ControllerBase
    {

        private readonly IOfficeService _officeService;
        private readonly IMapper _mapper;

        public OfficeController(IOfficeService officeService, IMapper mapper)
        {
            _officeService = officeService;
            _mapper = mapper;
        }

        //Get list of consultants
        [HttpGet]
        [ProducesResponseType(typeof(List<OfficeResponseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOffices()
        {
            var offices = _officeService.GetOffices();
            if (!offices.Any())
            {
                return NoContent();
            }
            var result = _mapper.Map<List<OfficeResponseDto>>(offices);
            return Ok(result);
        }

        ///Get a Consultant
        ///<param name="officeId"></param>
        [HttpGet("{officeId}")]
        [ProducesResponseType(typeof(OfficeResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetOffice([FromRoute] int officeId)
        {
            var offices = _officeService.GetOffice(officeId);
            if (offices == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<OfficeResponseDto>(offices);
            return Ok(result);
        }

    }
}
