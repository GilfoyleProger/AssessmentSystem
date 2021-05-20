using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class User_Information
    {
        [Key]
        public int Id { get; set; }
        public virtual int? User_Type_Id { get; set; }
        public virtual User_Type User_Type { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middle_Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
