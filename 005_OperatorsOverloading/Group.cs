namespace _005_OperatorsOverloading
{
    class Group
    {
        Student[] students;
        public Group(Student[] students)
        {
            this.students = students;
        }
        public override string ToString()
        {
            return string.Join("\n", students.Select(s => s.ToString()).ToArray());

            /*string res = string.Empty;
            foreach (Student student in students)
            {
                res += student + "\n";
            }
            return res;*/
        }

        public Student this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                if (index >= 0 && index < students.Length)
                {
                    students[index] = value;
                }
            }
        }

        public int FindIndexByName(string name)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == name) return i;
            }
            return -1;
        }

        public Student this[string name]
        {
            get
            {
                int index = FindIndexByName(name);
                    return students[index];
            }
           
        }

    }
}
