using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
       
        public virtual int? Major_Id { get; set; }
        public virtual Major Major { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject_Room> Subject_Rooms { get; set; }
    }
}
