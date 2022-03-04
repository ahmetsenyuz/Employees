using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Students : BasePerson
    {
        public int EducationId { get; set; }
        public int? LecturerId { get; set; }
        public string UniversityDep { get; set; }
        [ForeignKey("CountyId")]//buradaki cityIdyi al git city'nin primary keyiyle eşleştir.
        public virtual County County { get; set; }
        [ForeignKey("EducationId")]
        public virtual Education Education { get; set; }
        [ForeignKey("LecturerId")]
        public virtual Lecturer Lecturer { get; set; }
    }
}
