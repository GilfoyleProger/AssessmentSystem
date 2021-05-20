using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Chat
    {
        [Key]
        public int Id { get; set; }
        public virtual int? Subject_Room_Id { get; set; }
        public virtual Subject_Room Subject_Room { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
