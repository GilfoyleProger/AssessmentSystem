using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Department_Employee
    {
        [Key]
        public int Id { get; set; }
        public virtual int? Professor_Id { get; set; }
        public virtual Professor Professor { get; set; }
        public virtual int? Classes_Type_Id { get; set; }
        public virtual Classes_Type Classes_Type { get; set; }
        public virtual int? Curriculum_Id { get; set; }
        public virtual Curriculum Curriculum { get; set; }
    }
}
