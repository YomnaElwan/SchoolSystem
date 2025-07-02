using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Commands.Handlers
{
    public class StudentCommandHandler : ResponseHandler, IRequestHandler<AddStudentCommand, Response<string>>
    {
        private readonly IStudentService studentService;
        private readonly IMapper mapper;
        public StudentCommandHandler(IStudentService studentService, IMapper mapper)
        {
            this.studentService = studentService;
            this.mapper = mapper;
        }
        public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            var mappedStudents = mapper.Map<Student>(request);
            var result = await studentService.AddStudentAsync(mappedStudents);
            if (result == "Existing")
            {
                return unProcessableEntity<string>("This Name is already existing");
            }
            else if (result == "Student Added Successfully")
            {
                return Created<string>("Student has been added successfully");

            }
            else {
                return BadRequest<string>("Something went wrong, please try again!");
            }
           

            

            
                
            

        }
    }
}
