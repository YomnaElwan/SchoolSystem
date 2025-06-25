using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;

namespace SchoolProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        #region Fields
        private readonly IMediator _mediator;
        #endregion
        #region Constructor
        public StudentController(IMediator mediator)
        {
            this._mediator = mediator;
        }
        #endregion
       
        [HttpGet("/Student/List")]
        public async Task<IActionResult> GetStudentsList() {
            var response = await _mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }
    }
}
