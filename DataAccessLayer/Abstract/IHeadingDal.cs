using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    //17.ders 
    //tum tablolar için tek tek Generic İnterface olusturalım
    internal interface IHeadingDal:IRepository<Heading> //Buna  Generic İnterface denir
    {
    {
    }
}
