using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
  //  [Serializable]
    public class Major
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Group> Groups { get; set; }

        public Major()
        {
            
        }
        public Major(string name) 
        {
            Name = name;
        }
    }
}
