using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesImplementation
{
    interface IStudent
    {
         char grade { get; set; }
         float calculatepercentage(int marks);
         bool istoprank(int marks);

    }
}
