namespace Practice_AggegationAndContainment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Instructor will = new Instructor("Will", "Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming", "124", "J102", will);
            prog124.AddStudent("Ana", "Mendez", 100, 100);
            prog124.AddStudent("Cirella", "Smith", 90, 80);

            Console.WriteLine(will);
            Console.WriteLine(prog124);
            foreach (Student student in prog124.ClassRoster)
            {
                Console.WriteLine(student);
            }

        }
    }
}