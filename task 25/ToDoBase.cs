using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ToDoBase
{
    public List<ToDo> all = new List<ToDo>();
    string fp = "C:\\Users\\user\\Desktop\\с++ i c#\\frustration\\task 25\\baza.json";

    public void l()
    {
        if (File.Exists(fp))
        {
            string json = File.ReadAllText(fp);
            all = JsonSerializer.Deserialize<List<ToDo>>(json);
        }
    }

    public void s()
    {
        string json = JsonSerializer.Serialize(all, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fp, json);
    }

    public void a(ToDo p)
    {
        all.Add(p);
    }

    public void r(string name)
    {
        all.RemoveAll(p => p.FirstName == name);
    }
    public List<ToDo> GetPublic()
    {
        List<ToDo> list = new List<ToDo>();
        foreach (var p in all)
        {
            if (p.IsPublic) list.Add(p);
        }
        return list;
    }
}
