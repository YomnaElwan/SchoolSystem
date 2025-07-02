using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Abstracts;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Infrastructure.Repositories;
using SchoolProject.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Service.Implementations
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IStudentRepository _studentRepository;
        #endregion
        #region Constructors
        public StudentService(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        
        #endregion

        #region Handlers
        public async Task<List<Student>> GetStudentsListAsync()
        {
           
            return await _studentRepository.GetStudentsListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int id)
        {
           var student= _studentRepository.GetTableNoTracking()
                                               .Include(s=>s.Department)
                                               .Where(s=>s.StudId.Equals(id))
                                               .FirstOrDefault();
            return student??null;
        }

        public async Task<string> AddStudentAsync(Student student)
        {
            var studentExistingNameCheck = _studentRepository.GetTableNoTracking()
                                                            .Where(s => s.Name.Equals(student.Name))
                                                            .FirstOrDefault();
            if (studentExistingNameCheck != null) return "Existing";
            await _studentRepository.AddAsync(student);
            return "Student Added Successfully"; 
        }



        #endregion

    }
}
