using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    public interface IPiece
    {
        int LeftVal { get; }
        int RightVal { get; }
    }
}
