using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hours_Count { get; set; }
        public int Marks_Count { get; set; }
        public virtual int? Curriculum_Id { get; set; }
        public virtual Curriculum Curriculum { get; set; }
        public virtual ICollection<Student_Assessment> Student_Assessments { get; set; }
        public virtual ICollection<Test_Result> Test_Results { get; set; }
    }
}
