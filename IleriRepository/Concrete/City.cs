using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Concrete
{
    public class City : BaseTable
    {
        public City()
        {
            Counties = new HashSet<County>();
        }
        public virtual ICollection<County> Counties { get; set; }
    }
}
