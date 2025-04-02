using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_aspcore.Models
{
    internal class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
