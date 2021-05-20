using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Student_Assessment
    {
        [Key]
        public int Id { get; set; }
        public virtual int? Module_Id { get; set; }
        public virtual Module Module { get; set; }
        public virtual int? Student_Id { get; set; }
        public virtual Student Student { get; set; }
        public int Mark { get; set; }
        public virtual int? Assesment_Type_Id { get; set; }
        public virtual Assessment_Type Assessment_Type { get; set; }
    }
}
