using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class DepartmentSubject
    {
        [ForeignKey("Subject")]
        public int SubId { get; set; }
        public virtual Subject Subject { get; set; }
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }


    }
}
