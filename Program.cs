using EF1.dbcontext;
using EF1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1
{
    class Program
    {
        static void Main(string[] args)
        {
            var newStudent = new Student();

            //set student name

            newStudent.FirstMidName = "Bill";
            newStudent.LastName = "Gates";
            newStudent.EnrollmentDate = DateTime.Parse("2015-10-21");
            newStudent.ID = 100;

            //create DBContext object

            using (var dbCtx = new UniContextEntities())
            {

                //Add Student object into Students DBset
                dbCtx.Students.Add(newStudent);

                // call SaveChanges method to save student into database
                dbCtx.SaveChanges();

              
            }

           
        }
    }
}
