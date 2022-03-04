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
    public class CountyRepository : BaseRepository<County>, IBaseCountyRepository
    {
        public ComboBox GetCombobox(ComboBox cb)
        {
            cb.DataSource = Set().Select(x => new BaseDTO { Id = x.Id, Name = x.Name }).ToList();
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
            return cb;
        }
        public ComboBox GetCombobox(ComboBox cb,int a)
        {
            cb.DataSource = Set().Select(x => new  { Id = x.Id, Name = x.Name, cId = x.CityId }).Where(x=> x.cId == a).ToList();
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
