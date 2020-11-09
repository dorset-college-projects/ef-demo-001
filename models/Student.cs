using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1.models
{
    public partial class Student
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
           "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Student()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public System.DateTime EnrollmentDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
           "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
