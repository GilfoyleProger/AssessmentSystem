using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Assessment_Type
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student_Assessment> Student_Assessments { get; set; }
    }
}
