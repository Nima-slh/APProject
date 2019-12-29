using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APProject
{
    public class Lesson
    {
        public int Vahed { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public Lesson[] Pishniaz { get; set; }
        public Lesson[] Hamniaz { get; set; }
    }
}
