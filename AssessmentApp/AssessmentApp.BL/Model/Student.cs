using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public virtual int? User_Information_Id { get; set; }
        public virtual User_Information User_Information { get; set; }

        public virtual int? Group_Id { get; set; }
        public virtual Group Group { get; set; }
        public virtual ICollection<Test_Result> Test_Results { get; set; }
    }
}
