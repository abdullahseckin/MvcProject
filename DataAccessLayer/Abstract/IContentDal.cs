using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //17.ders 
    //tum tablolar için tek tek Generic İnterface olusturalım
    public interface IContentDal:IRepository<Context> //Buna  Generic İnterface denir
    {
    {
    }
}
