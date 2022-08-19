using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //18.ders
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c=new Context(); //context sınıfından bı nesne urettım
        DbSet<T> _object;      //_object? T degerine karsılık olrak gelen sınıfı tutuyor
        //peki 
        //soru? ben burada t degerıne karsılık olarak gelen sınıfı nasıl bulacagım?
        // bir constructor bulacagız kı objemıze deger ataması yapalım
        // T-->category,baslık,yazar,ıcerık?

        //constructor yapıcı metot ile bulacagım
        public GenericRepository() //Constructor Yapıcı Metod sınıf ısmı ıle aynıdır
        {
            _object=c.Set<T>(); // senın degerın Contexte bağlı olarak gonderılen T Degerıdir
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
;
        }

        public List<T> Listele()
        {
           return _object.ToList();
        }

        public List<T> Listele(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
