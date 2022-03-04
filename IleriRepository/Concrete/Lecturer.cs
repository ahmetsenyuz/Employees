using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Lecturer : BasePerson
    {
        public Lecturer()
        {
            Students = new HashSet<Students>();
        }
        public string AcademicTitle { get; set; }
        public decimal Salary { get; set; }
        public string Branch { get; set; }
        public int EducationId { get; set; }
        [ForeignKey("CountyId")]//buradaki cityIdyi al git city'nin primary keyiyle eşleştir.
        public virtual County County { get; set; }
        [ForeignKey("EducationId")]
        public virtual Education Education { get; set; }
        public virtual ICollection<Students> Students { get; set; }
        public override string GetTitle()
        {
            return AcademicTitle + " " + "Sn. " + Name + " " + Surname;
        }
    }
}
