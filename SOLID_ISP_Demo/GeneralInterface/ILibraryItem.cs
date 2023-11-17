using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP_Demo
{
    public interface ILibraryItem
    {

        string LibraryId { get; set; }
        string Title { get; set; }

    }
}
