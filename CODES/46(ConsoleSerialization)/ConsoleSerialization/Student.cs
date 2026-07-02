namespace ConsoleSerialization
{
    internal class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string ToUpper()
        {
            return Name.ToUpper();
        }
    }
}
