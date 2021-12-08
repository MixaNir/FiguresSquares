using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public interface IFigure
    {
        string name { get; set; }
        double Square();

    }
}
