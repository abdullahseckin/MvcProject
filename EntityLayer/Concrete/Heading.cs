using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(1000)]
        public string HeadingName { get; set; }
        
        public DateTime HeadingDate { get; set; }

        //ilişkiler A planı devamı

        public int CategoryID { get; set; }   //kategorıden aldık
        public virtual Category Category { get; set; } //bir siniftan(category) deger alacagım


        //ilişkiler B planı

        public ICollection<Content> Contents { get; set; } //1-sonsuz content ile


        // c planı devamı
        public int WriterID { get; set; }
        public virtual  Writer Writer { get; set; } //bir siniftan(Writer) deger alacagım


    }
}
