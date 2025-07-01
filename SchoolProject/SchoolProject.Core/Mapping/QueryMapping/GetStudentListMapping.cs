using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Mapping.StudentMapping
{
    public partial class StudentProfile
    {
        public void GetStudentsListMapping() {
            CreateMap<Student, GetStudentListResponse>().ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.DName));
        }
      
    }
}
