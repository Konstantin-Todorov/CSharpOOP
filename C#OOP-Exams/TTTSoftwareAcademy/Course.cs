namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Course : ICourse
    {
        private string name;

        public Course(string name , ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Topics = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public IList<string> Topics { get; set; }

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("{0}: Name={1}", this.GetType().Name, this.Name);

            if (this.Teacher != null)
            {
                output.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }

            if (this.Topics.Count > 0)
            {
                output.AppendFormat("; Topics=[{0}]", string.Join(", ", this.Topics));
            }

            return output.ToString();
        }
    }
}
