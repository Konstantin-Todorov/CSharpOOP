namespace HTMLRenderer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Element : BaseElement, IElement,IBaseElement
    {
        private ICollection<IBaseElement> childElement;

        public string TextContent { get; set; }

        public Element(string name, string content = null)
            :base(name)
        {
            this.TextContent = content;
            this.childElement = new List<IBaseElement>();
        }

        public IEnumerable<IBaseElement> ChildElements
        {
            get { return this.childElement; }
        }

        public void AddElement(IElement element)
        {
            this.childElement.Add(element);
        }

        public override void Render(StringBuilder output)
        {
            string format = "{1}{2}";
            
            if (!string.IsNullOrEmpty(Name))
            {
                format = "<{0}>" + format + "</{0}>";
            }

            output.AppendFormat(format,this.Name,this.HTMLEncode(this.TextContent),string.Join("",this.ChildElements));
        }

        private string HTMLEncode(string contend)
        {
            if (!string.IsNullOrEmpty(contend))
            {
                contend = contend.Replace("&", "&amp;")
                                 .Replace("<", "&lt;")
                                 .Replace(">", "&gt;");
            }

            return contend;
        }
    }
}
