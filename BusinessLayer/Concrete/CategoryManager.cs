using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    //19.ders BussinessLayer
    public class CategoryManager
    {
        //üzerinde calısacagım sınıfı cagırmam lazım
        // bu sınıfı neye bağlı olarak cagıracam (GenericRepository)

        GenericRepository<Category> repo=new GenericRepository<Category>();

        //CRUD işlemleri için
        public List<Category> GetAllBl()  //ismi ben verdım
        {
            return repo.Listele(); // repo.dan sonra Category içindeki CRUD metodları geldi Listele

        }
        public void CategoryAddBl( Category p)  //ismi ben verdım  CategoryAddBl
        {
            //burada bazı şartlar yazmam lazım
            // p.dan sonra Category içindeki CRUD metodları 
            if (p.CategoryName=="" ||p.CategoryName.Length<=5  ||p.CategoryDescription=="" ||p.CategoryName.Length>=50 )
            {
                //hata mesajı

            }
            else
            {
                repo.Insert(p); //hata yoksa ekleme yap
            }


        }
        
    }
}
