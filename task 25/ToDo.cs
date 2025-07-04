﻿public class ToDo
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Likes { get; set; }
    public bool IsPublic { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Likes} likes)\n{Text}";
    }
}


