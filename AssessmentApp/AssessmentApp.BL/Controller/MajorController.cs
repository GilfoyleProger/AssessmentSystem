using AssessmentApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentApp.BL.Controller
{
    public class MajorController : ControllerBase
    {
        public List<Major> Majors { get; }
      public  MajorController() 
        {
            Majors = GetAllMajors();
        }
        public void Add(string name)
        {
            var major = new Major(name);
            Majors.Add(major);

            Save();
        }
      /*  private List<Major> GetAllMajors()
        {
            return Load<Major>() ?? new List<Major>();
        }*/
         private List<Major> GetAllMajors()
         {
             return Load<Major>() ?? new List<Major>();
         }
        public List<Major> GetMajors() 
        {
            return Majors;
        }
        private void Save()
        {
            Save(Majors);
        }
        /*   private void Save()
           {
               Save(Majors);
           }*/
        //public addToDataBase() 
        //{
        
        //}
    }
}
