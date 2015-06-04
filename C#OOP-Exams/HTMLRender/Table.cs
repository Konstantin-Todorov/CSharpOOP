namespace HTMLRenderer
{
    using System.Text;

    public class Table : Element, ITable , IBaseElement
    {
        private const string TableName = "table";
        private IElement[,] matrix;
        
        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public Table(int rows, int cols)
            :base(TableName)
        {
            this.matrix = new IElement[rows, cols];
        }

        public IElement this[int row, int col]
        {
            get { return this.matrix[row, col]; }
            set { this.matrix[row, col] = value; }
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", base.Name);

            for (int r = 0; r < this.matrix.GetLength(0); r++)
            {
                output.Append("<tr>");
                
                for (int c = 0; c < this.matrix.GetLength(1); c++)
                {
                    output.AppendFormat("<td>{0}</td>", this.matrix[r, c]);
                }

                output.Append("</tr>");
            }

            output.AppendFormat("</{0}>", base.Name);
        }
    }
}
