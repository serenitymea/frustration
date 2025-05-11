class Program
{
    static void Main()
    {
        Course cou = new Course("course1", 3);

        Student student1 = new Student("Stupid", "Red", 11111);
        Student student2 = new Student("Ftupid", "Orange", 22222);
        Student student3 = new Student("Gtupid", "Blue", 33333);
        Student student4 = new Student("Htupid", "Green", 4444);


        cou.es(student1);
        cou.es(student2);
        cou.es(student3);
        cou.es(student4);
        cou.wrlofstud();


    }
}
