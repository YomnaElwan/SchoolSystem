using AutoMapper;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler :ResponseHandler, IRequestHandler<GetStudentListQuery,Response<List<GetStudentListResponse>>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public StudentHandler(IStudentService studentService,IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion
        #region Handler
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var studentsList= await _studentService.GetStudentsListAsync();
            var studentsListMapper = _mapper.Map<List<GetStudentListResponse>>(studentsList);
            return Success(studentsListMapper);
        }
        #endregion

    }
}
