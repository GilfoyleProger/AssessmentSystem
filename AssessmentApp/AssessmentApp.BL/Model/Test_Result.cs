using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Test_Result
    {
        [Key]
        public int Id { get; set; }
        public int Result_Mark { get; set; }
       
        public virtual int? Test_Id { get; set; }
        public virtual Test Test { get; set; }
        
        public virtual int? Module_Id { get; set; }
        public virtual Module Module { get; set; }
        public virtual int? Student_Id { get; set; }
        public virtual Student Student { get; set; }
    }
}
