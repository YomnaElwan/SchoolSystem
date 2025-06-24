using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class StudentSubject
    {
        [ForeignKey("Student")]
        public int StudId { get; set; }
        public virtual Student Student { get; set; }

        [ForeignKey("Subject")]
        public int SubId { get; set; }
        public virtual Subject Subject { get; set; }

    }
}
