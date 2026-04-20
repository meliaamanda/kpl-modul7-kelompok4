using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class TeamMembers103082400001
{
    public List<Member> members { get; set; }

    public class Member
    {
        public string nim { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_103082400001.json");
        var data = JsonSerializer.Deserialize<TeamMembers103082400001>(json);

        Console.WriteLine("Team member list:");
        foreach (var m in data.members)
        {
            Console.WriteLine($"{m.nim} {m.firstName} {m.lastName} ({m.age} {m.gender})");
        }
    }
}