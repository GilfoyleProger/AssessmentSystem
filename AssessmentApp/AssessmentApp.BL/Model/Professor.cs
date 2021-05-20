using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Professor
    {
        [Key]
        public int Id { get; set; }
        public virtual int? User_Information_Id { get; set; }
        public virtual User_Information User_Information { get; set; }
        public virtual ICollection<Department_Employee> Department_Employees { get; set; }
    }
}
