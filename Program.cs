namespace Practice_Aggregation_and_Containment_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // Practice - Aggregation and Containment
        // 02/09/2024
        static void Main(string[] args)
        {
            
            // Instances
            Instructor instructorWill = new Instructor("Will","Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming","124","J102",instructorWill);
            prog124.AddStudent("Ana", "Mendes", 100, 100);
            Console.WriteLine(prog124);
            Console.WriteLine(instructorWill);


            //foreach (Student s in prog124.ClassRoster )
            //{
                //Console.WriteLine(s);
            //}
        }
    }
}
// Done