using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(1000)]
        public string CategoryName { get; set; }
        [StringLength(1000)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //ilişkiler A planı
        public ICollection<Heading> Headings { get; set; }  //1-cok ilişki heading


    }
}
