using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
class Program
{
    static void Main()
    {
        var posts = load("C:\\Users\\user\\Desktop\\с++ i c#\\frustration\\task 29\\baza.json");

        var likes190 = posts.Where(p => p.Likes == 190).ToList();
        var public300 = posts.Where(p => p.IsPublic && p.Likes > 300).ToList();
        var last250 = posts.LastOrDefault(p => p.Likes == 250);
        var women = posts.Where(p => p.FirstName.EndsWith("a")).ToList();

        candsave(posts, "cleaned.json");

        if (posts.Count > 0)
            ftemp(posts[0], "C:\\Users\\user\\Desktop\\с++ i c#\\frustration\\task 29\\szablonPost.txt", "PostWynikowy.txt");

        Console.WriteLine("\nXXXXXXXXXXX\ncompleted\nXXXXXXXXXXX\n");
    }

    static List<Post> load(string file)
    {
        var text = File.ReadAllText(file);
        return JsonSerializer.Deserialize<List<Post>>(text);
    }

    static void candsave(List<Post> posts, string output)
    {
        var clean = posts.Where(p => p.IsPublic && p.Likes >= 200).ToList();
        var options = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(output, JsonSerializer.Serialize(clean, options));
    }

    static void ftemp(Post post, string tempf, string outf)
    {
        var t = File.ReadAllText(tempf);
        t = t.Replace("{FirstName}", post.FirstName)
             .Replace("{LastName}", post.LastName)
             .Replace("{Likes}", post.Likes.ToString())
             .Replace("{Text}", post.Text);
        File.WriteAllText(outf, t);
    }
}
