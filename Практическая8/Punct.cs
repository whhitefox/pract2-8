using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая8
{
    public class Punct
    {
        public string name { get; set; }
        public string image { get; set; }
        public bool selected { get; set; }

        public Punct(string name, string image, bool selected)
        {
            this.name = name;
            this.image = image;
            this.selected = selected;
        }
    }
}
