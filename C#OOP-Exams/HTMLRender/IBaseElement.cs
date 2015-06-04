namespace HTMLRenderer
{
    using System.Text;
    
    public interface IBaseElement
    {
        string Name { get; }
        void Render(StringBuilder output);
        string ToString();
    }
}
