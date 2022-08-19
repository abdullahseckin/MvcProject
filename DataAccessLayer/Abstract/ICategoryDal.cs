using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //17.ders 
    //tum tablolar için tek tek Generic İnterface olusturalım
    public interface ICategoryDal:IRepository<Category>  //Buna  Generic İnterface denir
    {
    }
}
