using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName="varchar")]
        public string Name { get; set; }
    }
}
