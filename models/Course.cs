using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1.models
{
    public partial class Course
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
           "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public Course()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }

        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage",
           "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
