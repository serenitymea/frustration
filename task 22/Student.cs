class Student
{
    public string n { get; set; }
    public string s { get; set; }
    public int ni { get; set; }

    public Student(string name, string surname, int nii)
    {
        n = name;
        s = surname;
        ni = nii;
    }

    public string desc()
    {
        return $"{n} {s}, index: {ni}";
    }
}
