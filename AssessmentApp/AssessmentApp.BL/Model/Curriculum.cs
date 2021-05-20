using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Curriculum
    {
        [Key]
        public int Id { get; set; }
        public virtual int? Subject_Id { get; set; }
        public virtual Subject Subject { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime End_Time { get; set; }
        public int Credits { get; set; }
        public int Hours_Count { get; set; }
        public virtual ICollection<Department_Employee> Department_Employees { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<Subject_Room> Subject_Rooms { get; set; }
    }
}
