using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public class FileLoggerAdapter : Logger
    {
        private readonly IFileWriter _fileWriter;
        private readonly ConsoleColor _defaultColor = Console.ForegroundColor;

        public FileLoggerAdapter(IFileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public new void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _fileWriter.WriteLine($"[LOG] {message}");
            Console.ForegroundColor = _defaultColor;
        }

        public new void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            _fileWriter.WriteLine($"[ERROR] {message}");
            Console.ForegroundColor = _defaultColor;
        }

        public new void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            _fileWriter.WriteLine($"[WARN] {message}");
            Console.ForegroundColor = _defaultColor;
        }
    }
}
