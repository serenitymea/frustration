using task_27;

class Program
{
    static void Main()
    {
        ToDoBase db = new();
        db.Load();

        while (true)
        {
            Console.WriteLine("\n1.Add\n2.Show\n3.Exit");
            var c = Console.ReadLine();

            if (c == "1")
            {
                Console.Write("1: ");
                var name = Console.ReadLine();
                Console.Write("2: ");
                var desc = Console.ReadLine();
                db.Add(new ToDo { Name = name, Desc = desc });
            }
            else if (c == "2")
                db.ShowAll();
            else if (c == "3")
            {
                db.Save();
                Console.WriteLine("saved");
                break;
            }
        }
    }
}