using AssessmentApp.BL;
using AssessmentApp.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentApp.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UserContext())
            {
                var professor = new Professor();

                context.Professors.Add(professor);
                context.SaveChanges();

                Console.WriteLine($"id: {professor.Id}");
                Console.ReadLine();
            }
        }
    }
}
