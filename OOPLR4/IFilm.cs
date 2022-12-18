using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR4
{
    public interface IFilm : IArt
    {
        int Mark { get; set; }
        int Style { get; set; }
    }
}
