using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace task_27
{
    class ToDoBase
    {
        public List<ToDo> List = new();
        string file = "todos.json";

        public void Load()
        {
            if (File.Exists(file))
                List = JsonSerializer.Deserialize<List<ToDo>>(File.ReadAllText(file));
        }

        public void Save()
        {
            File.WriteAllText(file, JsonSerializer.Serialize(List));
        }

        public void Add(ToDo todo)
        {
            List.Add(todo);
        }

        public void ShowAll()
        {
            foreach (var t in List)
                Console.WriteLine($"{t.Name} - {t.Desc}");
        }
    }

}
