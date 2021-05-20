using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual int? Subject_Room_Id { get; set; }
        public virtual Subject_Room Subject_Room { get; set; }
        public virtual ICollection<Test_Result> Test_Results { get; set; }
    }
}
