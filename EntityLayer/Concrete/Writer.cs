﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public  class Writer
    {
        [Key]
        public int WriterID { get; set; }
        [StringLength(100 )]
        public string WriterName { get; set; }
        [StringLength(100)]
        public string WriterSurName { get; set; }
        [StringLength(100)]
        public string WriterImage { get; set; }
        [StringLength(100)]
        public string WriterMail { get; set; }
        [StringLength(10)]
        public string WriterPassword { get; set; }


        //ilişkiler C Planı Yazar-->heading arasında
        public ICollection<Heading> Headings { get; set; }

        //ilişkiler D Planı Yazar-->content arasında
        public ICollection<Content> Contents { get; set; }





    }
}
