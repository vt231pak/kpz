using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public interface IFileWriter
    {
        void Write(string message);
        void WriteLine(string message);
    }
}
