namespace School
{
    using System;
    using System.Collections.Generic;
    
    public class Teacher : People 
    {
        //private string name;
        private List<Discipline> disciplines;

        public Teacher(string name)
        {
            this.Name = name;
        }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }
            protected set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.disciplines = value; 
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void AddDiscipline(params Discipline[] disciplines)
        {
            for (int i = 0; i < disciplines.Length; i++)
            {
                this.disciplines.Add(disciplines[i]);
            }
        }
       
        public override string ToString()
        {
            return string.Format("Discipline :{0} ", this.Name);
        }
        
        //public string Name
        //{
        //    get { return this.name; }
        //    protected set 
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentNullException();
        //        }
                
        //        this.name = value; 
        //    }
        //}
    }
}
