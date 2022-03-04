using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Repositories.BaseRepository.Abstract
{
    public interface IBaseCountyRepository : IBaseTableRepository
    {
        ComboBox GetCombobox(ComboBox cb,int a);
    }
}
