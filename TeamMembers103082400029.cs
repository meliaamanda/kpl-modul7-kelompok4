using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class TeamMembers103082400029
{
    public List<Member> members { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_2_103082400029.json");

        TeamMembers103082400029 data = JsonSerializer.Deserialize<TeamMembers103082400029>(jsonString);

        Console.WriteLine("\nTeam Member List :");

        foreach (var m in data.members)
        {
            Console.WriteLine($"{m.nim} {m.firstName} {m.lastName} ({m.age} {m.gender})");
        }
    }
}

public class Member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string nim { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
}