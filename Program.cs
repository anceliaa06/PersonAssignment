namespace PersonAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
                (id: 1, address: "lonavla", dob: new DateTime(2000, 1, 1), branch: "CSE");

            Console.WriteLine($"Student ID: {student.Id}, Address: {student.Address}, DOB: {student.Dob.ToShortDateString()}, Branch: {student.Branch}");

            Professor professor = new Professor
                (id: 2, address: "Mumbai", dob: new DateTime(1980, 5, 15), baseSalary: 80000m, experienceYears: 10, department: "Computer Science");

            Console.WriteLine($"\nProfessor Info:\nID: {professor.Id}, Dept: {professor.Department}, Salary: ₹{professor.CalculateSalary()}, DOB: {professor.Dob.ToShortDateString()}, Address: {professor.Address}");
        }
    }
}
