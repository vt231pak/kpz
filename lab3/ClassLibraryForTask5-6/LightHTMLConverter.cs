using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask5_6
{
    public class LightHTMLConverter
    {
        public static List<LightNode> ConvertTextToHTML(string text)
        {
            List<LightNode> nodes = new List<LightNode>();

            string[] lines = text.Split('\n');

            bool isFirstLine = true;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (isFirstLine)
                {
                    nodes.Add(new LightHeaderNode(line.Trim()));
                    isFirstLine = false;
                }
                else if (line.Length < 20)
                {
                    nodes.Add(new LightSecondHeaderNode(line.Trim()));
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    nodes.Add(new LightBlockquoteNode(line.Trim()));
                }
                else
                {
                    nodes.Add(new LightParagraphNode(line.Trim()));
                }
            }

            return nodes;
        }
    }
}
