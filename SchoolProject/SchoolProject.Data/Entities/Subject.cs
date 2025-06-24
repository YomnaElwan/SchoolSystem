using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Subject
    {
        public Subject()
        {
            DepartmentSubjects = new HashSet<DepartmentSubject>();
            StudentSubjects = new HashSet<StudentSubject>();
        }
        [Key]
        public int SubId { get; set; }
        public string SubName { get; set; }
        public DateTime Period { get; set; }

        public virtual ICollection<DepartmentSubject> DepartmentSubjects { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
