namespace HTMLRenderer
{
    using System.Text;
    using System.Collections.Generic;

    public abstract class BaseElement : IBaseElement
    {
        public string Name { get; private set; }

        public BaseElement(string name)
        {
            this.Name = name;
        }

        public abstract void Render(StringBuilder output);

        public override string ToString()
        {
            var sb = new StringBuilder();
            this.Render(sb);

            return sb.ToString();
        }
    }

}
