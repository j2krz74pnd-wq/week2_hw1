// // class Person
// // {
// //     public string FirstName;
// //     public string LastName;
// //     public int Age;

// //     public void GetInfo()
// //     {
// //         Console.WriteLine($"FirstName: {FirstName}");
// //         Console.WriteLine($"LastName: {LastName}");
// //         Console.WriteLine($"Age: {Age}");
// //     }
// // }


// // class Post
// // {
// //     public string Text = "";
// //     public int Likes;
// //     public List<string> Comments = new List<string>();

// //     public void SetPost(string text)
// //     {
// //         Text = text;
// //     }

// //     public void AddLike()
// //     {
// //         Likes++;
// //     }

// //     public void AddComment(string comment)
// //     {
// //         Comments.Add(comment);
// //     }

// //     public void GetInfo()
// //     {
// //         Console.WriteLine($"Text = {Text}");
// //         Console.WriteLine($"Likes : {Likes}");
// //         Console.WriteLine("Comments :");
// //         for (int i = 0; i < Comments.Count; i++)
// //         {
// //             Console.WriteLine(Comments[i]);
// //         }
// //     }
// // }


// class Player
// {
//     public string Name = "";
//     public int Number;
//     public string Position = "";
//     public string Team = "";

//     public void ScoreGoal()
//     {
//         Console.WriteLine($"{Name} scores a goal!");
//     }

//     public void AssistGoal(string playerName)
//     {
//         Console.WriteLine($"{Name} assists a goal for {playerName}.");
//     }

//     public void GetInfo()
//     {
//         Console.WriteLine($"Name: {Name}");
//         Console.WriteLine($"Number: {Number}");
//         Console.WriteLine($"Position: {Position}");
//         Console.WriteLine($"Team: {Team}");
//     }
// }


class Employee
{
    public string FirstName = "";
    public string LastName = "";
    public int Age;
    public string Position = "";
    public decimal Salary;

    public void SetSalary(decimal salary)
    {
        Salary = salary;
    }

    public decimal GetSalary()
    {
        return Salary;
    }

    public void GetInfo()
    {
        Console.WriteLine($"FirstName: {FirstName}");
        Console.WriteLine($"LastName: {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Salary: {Salary.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}