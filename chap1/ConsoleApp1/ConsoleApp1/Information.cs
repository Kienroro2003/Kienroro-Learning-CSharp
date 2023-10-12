namespace ConsoleApp1
{
    public class Information
    {
        private int id;
        private string name;
        private int age;
        private string nameClass;

        public Information()
        {
        }

        public Information(int id, string name, int age, string nameClass)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.nameClass = nameClass;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string NameClass
        {
            get => nameClass;
            set => nameClass = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}