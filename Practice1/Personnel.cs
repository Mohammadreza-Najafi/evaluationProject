using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    interface Personnel
    {
       string Name { get; set; }

       void ShowName();

       void WritePosition();
    }
}
