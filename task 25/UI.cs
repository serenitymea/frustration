using System;

public class UI
{
    private ToDoBase db = new ToDoBase();

    public void Run()
    {
        db.l();

        while (true)
        {
            Console.WriteLine("\n1. add post\n2. remove post\n3. show all\n4. save");
            Console.Write("Choice: ");
            var c = Console.ReadLine();

            if (c == "4") { db.s(); Console.WriteLine("saved");}

            switch (c)
            {
                case "1": addp(); break;
                case "2": rp(); break;
                case "3": sp(); break;
                default: Console.WriteLine("XXXXXXXXX"); break;
            }
        }
    }

    void addp()
    {
        Console.Write("First name: "); string f = Console.ReadLine();
        Console.Write("Last name: "); string l = Console.ReadLine();
        Console.Write("Content: "); string t = Console.ReadLine();
        Console.Write("Likes: "); int likes = int.Parse(Console.ReadLine());

        db.a(new ToDo { FirstName = f, LastName = l, Text = t, Likes = likes});
        Console.WriteLine("added");
    }

    void rp()
    {
        Console.Write("name to remove: ");
        db.r(Console.ReadLine());
        Console.WriteLine("removed");
    }
    void sp()
    {
        var list = db.GetPublic();
        if (list.Count == 0) Console.WriteLine("XXXXXXXXX");
        else foreach (var p in list) Console.WriteLine(p + "\n");
    }

}
