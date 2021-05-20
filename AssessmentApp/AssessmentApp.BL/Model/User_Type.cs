using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class User_Type
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<User_Information> User_Informations { get; set; }
    }
}
