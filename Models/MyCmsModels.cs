using System;
using System.ComponentModel.DataAnnotations;

namespace myCMS.Models
{ 

public class Category {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        




        }

public class Articles {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public int CategoryId { get; set; }
       
        }



}