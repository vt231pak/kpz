using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibraryForTask4
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private readonly Regex _regex;

        public SmartTextReaderLocker(string pattern)
        {
            _regex = new Regex(pattern);
        }

        public new char[][] ReadText(string filePath)
        {
            if (_regex.IsMatch(filePath))
            {
                Console.WriteLine("Доступ заборонено!");
                return null;
            }
            else
            {
                return base.ReadText(filePath);
            }
        }
    }
}
