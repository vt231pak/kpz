using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask5_6
{
    public class LightBlockquoteNode : LightNode
    {
        public string Text { get; }

        public LightBlockquoteNode(string text)
        {
            Text = text;
        }

        public override string OuterHtml => $"<blockquote>{Text}</blockquote>";
        public override string InnerHtml => OuterHtml;
    }
}
