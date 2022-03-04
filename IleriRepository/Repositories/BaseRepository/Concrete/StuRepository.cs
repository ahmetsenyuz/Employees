using IleriRepository.Concrete;
using IleriRepository.DTO;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class StuRepository : BaseRepository<Students>, IStuRepository
    {
        public List<PersonDTO> SummaryList()
        {
            return Set().Select(x => new PersonDTO { Id = x.Id, Name = x.Name, Surname = x.Surname }).ToList();
        }
    }
}
