using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask5_6
{
    public class LightHeaderNode : LightNode
    {
        public string Text { get; }

        public LightHeaderNode(string text)
        {
            Text = text;
        }

        public override string OuterHtml => $"<h1>{Text}</h1>";
        public override string InnerHtml => OuterHtml;
    }
}
