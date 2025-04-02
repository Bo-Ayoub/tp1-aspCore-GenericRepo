using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_aspcore.Models
{
    internal class Student
    {
        [Key]
        public int StudentNumber { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
