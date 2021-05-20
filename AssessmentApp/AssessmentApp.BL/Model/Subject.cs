using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AssessmentApp.BL.Model
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Curriculum> Curriculums { get; set; }
    }
}
