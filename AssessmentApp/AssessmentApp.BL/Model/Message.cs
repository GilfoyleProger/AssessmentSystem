using System;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public DateTime Time{ get; set; }
        public int Seen { get; set; }
       
        public virtual int? Chat_Id { get; set; }
        public virtual Chat Chat { get; set; }
        
        public virtual int? User_Information_Id { get; set; }
        public virtual User_Information User_Information { get; set; }
    }
}
