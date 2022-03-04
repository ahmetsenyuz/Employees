using IleriRepository.Concrete;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class PersonRepository : BaseRepository<BasePerson>, IPersonRepository//T yerine BasePerson yazdık. Basepersona ait her şey person repositorye geldi.
        //ÖNEMLİ BU!!
    {
        //BasePerson bp = new BasePerson();
        //public List<string> GetAddress()
        //{
        //    //List<string> alist = new List<string>();
        //    //alist.Add(GetTitle());
        //    //var adres = GetAddress();
        //    //foreach (var item in adres)
        //    //{
        //    //    alist.Add(item);
        //    //}
        //    return bp.GetAddress();
        //}

        //public int GetAge()
        //{
        //    return bp.GetAge();
        //}

        //public string GetTitle()
        //{
        //    //return "Sn. " + Set().Select(x => x.Name + " " + x.Surname); basepersonda method olmasaydı böyle yapacaktık.
        //    //return "Sn. " + bp.Name + " " + bp.Surname;  newlemekl lazımmış. newleyince böyle yapılabilir.
        //    return bp.GetTitle();
        //}
    }
}
