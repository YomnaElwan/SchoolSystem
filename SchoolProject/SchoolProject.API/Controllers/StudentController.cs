using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.AppMetaData;

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
       
        [HttpGet(Router.Student.GetList)]
        public async Task<IActionResult> GetStudentsList() {
            var response = await _mediator.Send(new GetStudentListQuery());
            return Ok(response);
        }

        [HttpGet(Router.Student.GetById)]
        public async Task<IActionResult> GetStudentById([FromRoute] int id)
        {
            var response = await _mediator.Send(new GetStudentByIdQuery(id));
            return Ok(response);
        }
    }
}
