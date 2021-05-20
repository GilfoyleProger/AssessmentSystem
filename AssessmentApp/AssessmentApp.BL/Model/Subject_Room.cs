using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Subject_Room
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual int? Group_Id { get; set; }
        public virtual Group Group { get; set; }
        public virtual int? Curriculum_Id { get; set; }
        public virtual Curriculum Curriculum { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }

    }
}
