using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrastructure.Abstracts
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetStudentsListAsync();
    }
}
