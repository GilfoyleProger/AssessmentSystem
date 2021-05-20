using AssessmentApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentApp.BL
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DbConnection") 
        { 
        }
      
        public DbSet<User_Information> User_Informations { get; set; }
        public DbSet<Assessment_Type> Assessment_Types { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Classes_Type> ClassesTypes { get; set; }
        public DbSet<Curriculum> Curriculums { get; set; }
        public DbSet<Department_Employee> DepartmentEmployees { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Assessment> Student_Assessments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Subject_Room> Subject_Rooms { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Test_Result> Test_Results { get; set; }
        public DbSet<User_Type> User_Types { get; set; }
    }
}
