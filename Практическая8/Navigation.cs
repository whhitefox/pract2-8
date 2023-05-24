using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Практическая8
{
    public class Navigation
    {
        public static Frame frame { get; set; }

        public static void ChagePage(Page page)
        {
           frame.Content = page;
        }
    }
}
