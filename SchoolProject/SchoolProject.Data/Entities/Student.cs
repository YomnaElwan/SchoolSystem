using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Student
    {
        public Student()
        {
            StudentSubjects = new HashSet<StudentSubject>();
        }
        [Key]
        public int StudId { get; set; }
        [StringLength(200)]
        [Required]
        public string Name { get; set; }
        public string? Address { get; set; }
        [StringLength(500)]
        public string? Phone { get; set; }
        [ForeignKey("Department")]

        public int? DID { get; set; }
        public virtual Department Department { get; set; }

        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }


    }
}
