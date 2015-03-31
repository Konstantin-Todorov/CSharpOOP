namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Group
    {
        //Problem 16
        private int groupNumber;
        private string departamentName;

        public Group(int groupNumber,string departamentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartamentName = departamentName;
        }

        public string DepartamentName
        {
            get { return departamentName; }
            set { departamentName = value; }
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        
    }
}
