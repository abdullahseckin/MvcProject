using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDalYanlısOrnek
    {
        //14.ders  (BU ANLATIM YANLIŞŞŞŞŞ)
        //CRUD operasyanlarını birer Metot olarak tanımla
        //metod type Name(); seklınde
        //listeme metodu
        //Sadecce FARKI GORUN DİYE yapildı
          
        List<Category> Listele();

        void Insert(Category p);  //categorilerden p parametre yardımı ıle EKLEME
        void Update(Category p);  //categorilerden p parametre yardımı ıle  GUNCELLE
        void Delete(Category p);  //categorilerden p parametre yardımı ıle  SİL

        //bu yontem kullanıslı değil!!!!!!!! 
        //her seferınde butun tablolar ıcın ayrı ayrı yapamam
        //elinde 10.000 tablo varsa nasıl yapacakksın

    }
}
