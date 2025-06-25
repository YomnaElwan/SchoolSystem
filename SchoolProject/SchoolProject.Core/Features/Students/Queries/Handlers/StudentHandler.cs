using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        #endregion

        #region Constructor
        public StudentHandler(IStudentService studentService)
        {
            this._studentService = studentService;
        }
        #endregion
        #region Handler
        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsListAsync();
        }
        #endregion

    }
}
