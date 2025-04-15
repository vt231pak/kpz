using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask5_6
{
    public class LightSecondHeaderNode : LightNode
    {
        public string Text { get; }

        public LightSecondHeaderNode(string text)
        {
            Text = text;
        }

        public override string OuterHtml => $"<h2>{Text}</h2>";
        public override string InnerHtml => OuterHtml;
    }
}
