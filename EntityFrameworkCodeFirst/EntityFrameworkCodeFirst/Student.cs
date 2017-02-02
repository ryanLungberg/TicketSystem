using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
   public class Student
    {
        //classNameID ex. StudentID
        //specify it is primary key
        [Key]
        public int StudentID { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "varchar")]
        public string name { get; set; }

        public DateTime? DateOfBirth { get; set; } //nullable datetime

        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string FavoriteColor { get; set; }

    }
}
