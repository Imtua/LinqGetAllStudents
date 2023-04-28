using LinqGetAllStudents;

var classes = new List<Classroom>()
{
    new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
    new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
    new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
};

var students = GetAllStudents(classes.ToArray());

foreach (var student in students)
{
    Console.WriteLine(student);
}

static string[] GetAllStudents(Classroom[] classrooms)
{
    var allStudents = (from classroom in classrooms
                       from student in classroom.Students
                       select student).ToArray();
    return allStudents;
}