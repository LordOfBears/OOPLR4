using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLR4
{
    public interface ISerial : IFilm
    {
        int NumberParts { get; set; }
    }
}
