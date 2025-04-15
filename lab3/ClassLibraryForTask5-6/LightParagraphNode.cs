using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask5_6
{
    public class LightParagraphNode : LightNode
    {
        public string Text { get; }

        public LightParagraphNode(string text)
        {
            Text = text;
        }

        public override string OuterHtml => $"<p>{Text}</p>";
        public override string InnerHtml => OuterHtml;
    }
}
