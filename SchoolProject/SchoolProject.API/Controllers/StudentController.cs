using MediatR;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.API.Base;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.AppMetaData;

namespace SchoolProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : AppControllerBase
    {
     
    
       
        [HttpGet(Router.Student.GetList)]
        public async Task<IActionResult> GetStudentsList() {
            var response = await MediatorInstance.Send(new GetStudentListQuery());
            return NewResult(response);
        }

        [HttpGet(Router.Student.GetById)]
        public async Task<IActionResult> GetStudentById([FromRoute] int id)
        {
            var response = await MediatorInstance.Send(new GetStudentByIdQuery(id));
            return NewResult(response);
        }
        [HttpPost(Router.Student.AddStudent)]
        public async Task<IActionResult> AddStudent([FromBody] AddStudentCommand addStudent)
        {
            var response = await MediatorInstance.Send(addStudent);
            return NewResult(response);
        }
        
    }
}
