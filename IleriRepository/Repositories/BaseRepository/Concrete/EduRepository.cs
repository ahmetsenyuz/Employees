using IleriRepository.Concrete;
using IleriRepository.DTO;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class EduRepository : BaseRepository<Education>, IBaseEduRepository
    {
        public ComboBox GetCombobox(ComboBox cb)
        {
            cb.DataSource = Set().Select(x => new BaseDTO { Id = x.Id, Name = x.Name }).ToList();
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
            return cb;
        }

        public List<BaseDTO> GetOption()
        {
            return Set().Select(x => new BaseDTO { Id = x.Id, Name = x.Name }).ToList();
        }
    }
}
