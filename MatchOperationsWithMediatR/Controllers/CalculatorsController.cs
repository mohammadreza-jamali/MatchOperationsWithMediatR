using Application.Mediator.Devides;
using Application.Mediator.Multiplies;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MatchOperations.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CalculatorsController(IMediator mediator) => _mediator = mediator;

        [HttpGet(template:"multiply")]
        public async Task<ActionResult> Multiply(int firstNumber, int secondNumber)
        {
            return Ok(await _mediator.Send(new MultiplyRequest() { FirstNumber = firstNumber, SecondNumber = secondNumber }));
        }

        [HttpGet(template: "divide")]
        public async Task<ActionResult> Divide(int firstNumber, int secondNumber)
        {
            return Ok(await _mediator.Send(new DevideRequest() { FirstNumber = firstNumber, SecondNumber = secondNumber }));
        }
    }
}
