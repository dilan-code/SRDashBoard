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
    public class ConsultantAccountController : ControllerBase
    {
        private readonly IConsultantAccountService _consultantAccountService;
        private readonly IMapper _mapper;

        public ConsultantAccountController(IConsultantAccountService consultantAccountService, IMapper mapper)
        {
            _consultantAccountService = consultantAccountService;
            _mapper = mapper;
        }

        //Get list of consultants
        [HttpGet]
        [ProducesResponseType(typeof(List<ConsultantAccountResponseDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetConsultantAccounts()
        {
            var consultantAccounts = _consultantAccountService.GetConsultantAccounts();
            if (!consultantAccounts.Any())
            {
                return NoContent();
            }
            var result = _mapper.Map<List<ConsultantResponseDto>>(consultantAccounts);
            return Ok(result);
        }

        ///Get a Consultant
        ///<param name="consultantAccountId"></param>
        [HttpGet("{consultantAccountId}")]
        [ProducesResponseType(typeof(ConsultantAccountResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetConsultantAccount([FromRoute] int consultantAccountId)
        {
            var consultantAccounts = _consultantAccountService.GetConsultantAccount(consultantAccountId);
            if (consultantAccounts == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<ConsultantAccountResponseDto>(consultantAccounts);
            return Ok(result);
        }
    }
}