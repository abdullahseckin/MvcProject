using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //15.ders Tanımladılgımız CRUD metotlarını Görevlerni yazacagız
    // bu yontem aslında yanlıs bir yontem ama gorunmesı acısında anlatılacak
    //ICategoryDal dan kalıtım alacak
    //1.using DataAccessLayer.Abstract; ekle
    //2.Crud metotları için İmplementler ekle
    public class CategoryRepository : ICategoryDalYanlısOrnek
    {
        //BU ANLATIM YANLIŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞ
        //bu sekılde calısmaz
        //cagırmamız gereken 2 ifade var
       
        Context c=new Context();  //c nesnesi türektık
       DbSet<Category> _object;  // bir field lazım _object (DbSet turunden)

        public void Delete(Category p)
        {
            _object.Remove(p); //Silme metot gorevı tanımlandı
            c.SaveChanges();
        }

        public void Insert(Category p)
        {
            _object.Add(p);  //EKLEMME metot gorevı tanımlandı
            c.SaveChanges();  // ado.net de karsılıgı ?
        }

        public List<Category> Listele()
        {
            
            return _object.ToList();  //listeme metot gorevı tanımlandı
        }

        public void Update(Category p)
        {
            c.SaveChanges(); //update metot gorevı tanımlandı
        }
        
        //17.ders sartlı sorgu devamı
        //public List<Category> Listele(Expression<Func<Category,bool>> filter)
        //{

        //}
    }
}
