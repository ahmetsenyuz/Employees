using IleriRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Repositories.BaseRepository.Abstract
{
    public interface IBaseTableRepository
    {
        ComboBox GetCombobox(ComboBox cb);
        //ComboBox GetCombobox(ComboBox cb,int a);//web programlamada kullanamayız.
        List<BaseDTO> GetOption();//w3schools bak.HTML de select option var.
    }
}
