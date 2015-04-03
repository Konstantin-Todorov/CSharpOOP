namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name,ITeacher teacher ,string lab)
            : base(name,teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                this.lab = value;
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("LocalCourse: Name={0};", this.Name);

            if (this.Teacher != null)
                result.AppendFormat(" Teacher={0};", this.Teacher.Name);

            if (this.Topics.Count > 0)
                result.AppendFormat(" Topics=[{0}];", string.Join(", ", this.Topics));

            result.AppendFormat(" Lab={0}", this.Lab);

            return result.ToString();
        } 
    }
}
