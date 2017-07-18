using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGlue.Api.Controllers.Computers.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AppGlue.Api.Controllers.Computers
{
    [Route("api/[controller]")]
    public class ComputersController : BaseController
    {
        private readonly IMediator _mediator;

        public ComputersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id:int}", Name = "GetComputer")]
        public async Task<IActionResult> GetById(GetById.Query query)
        {
            var result = await _mediator.Send(query);
            if (result.NotFound)
            {
                return NotFound();
            }

            return Ok(result.Model);
        }
    }
}
