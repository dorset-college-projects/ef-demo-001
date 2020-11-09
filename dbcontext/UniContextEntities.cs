using EF1.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1.dbcontext
{
    public partial class UniContextEntities : DbContext
    {

       public UniContextEntities() : base("name = UniContextEntities") { }
     
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
        //   throw new UnintentionalCodeFirstException();
     }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}
