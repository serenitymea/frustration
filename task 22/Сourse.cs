class Course
{
    public string noc { get; set; }
    public int maxs { get; set; }
    private List<Student> stud;

    public Course(string nocc, int maxss)
    {
        noc = nocc;
        maxs = maxss;
        stud = new List<Student>();
    }

    public void es(Student studd)
    {
        if (stud.Count < maxs)
        {
            stud.Add(studd);
            Console.WriteLine($"enrolled student: {studd.desc()}");
        }
        else
        {
            Console.WriteLine($"full course, not enrolled: {studd.desc()}");
        }
    }

    public void wrlofstud()
    {
        Console.WriteLine($"\nlist {noc}:");
        int n = 1;
        foreach (var student in stud)
        {
            Console.WriteLine($"\n{n}.{student.desc()}");
            n++;
        }
    }
}