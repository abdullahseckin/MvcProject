using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //16.ders
        // T-->Entity
        // T-->bu artık Category,Writer,headıng.... yerıne kullanıluacak
        // artık her tablo ıcın ayrı ayrı tanımlama yapmama gerek yok
        //e tıcaret ıcın daha uygun 100000 tablo old dusun
        List<T> Listele();
        void Insert (T p);
        void Update (T p);
        void Delete (T p);
        
        //17.ders şartlı listeleme
        List<T> Listele (Expression <Func<T,bool>> filter);


        //17.ders Generic Interface gecelim





    }
}
