using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask5_6
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public string DisplayType { get; }
        public string ClosingType { get; }
        public List<LightNode> Children { get; }
        public List<string> CssClasses { get; }

        public LightElementNode(string tagName, string displayType, string closingType, List<LightNode> children, List<string> cssClasses = null)
        {
            TagName = tagName;
            DisplayType = displayType;
            ClosingType = closingType;
            Children = children;
            CssClasses = cssClasses ?? new List<string>();
        }

        public override string OuterHtml
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"<{TagName} class=\"{string.Join(" ", CssClasses)}\">");
                if (Children.Count > 0)
                {
                    foreach (var child in Children)
                    {
                        sb.Append(child.OuterHtml);
                    }
                }
                sb.Append($"</{TagName}>");
                return sb.ToString();
            }
        }

        public override string InnerHtml
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                if (Children.Count > 0)
                {
                    foreach (var child in Children)
                    {
                        sb.Append(child.InnerHtml);
                    }
                }
                return sb.ToString();
            }
        }
    }
}
