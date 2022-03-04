using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class Employees : BasePerson
    {
        public decimal Salary { get; set; }
        public int EducationId { get; set; }
        [ForeignKey("CountyId")]//buradaki cityIdyi al git city'nin primary keyiyle eşleştir.
        public virtual County County { get; set; }
        [ForeignKey("EducationId")]
        public virtual Education Education { get; set; }
    }
}
