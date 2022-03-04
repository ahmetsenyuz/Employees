using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Abstract
{
    public interface IBaseRepository<T> where T: class
    {
        void Update();//hata yoksa true hata varsa false döndürür.
        bool Delete(T entity);
        bool Add(T entity);
        T Find(int Id);
        List<T> List();
        DbSet<T> Set();
    }
}
