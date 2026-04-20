using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace modul7_Kelompok_4
{
    internal class TeamMembers_103082400039
    {
        public List<Member> members { get; set; }

        public class Member
        {
            public string nim { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public int age { get; set; }
            public string gender { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_2_103082400039.json");
            TeamMembers_103082400039 data = JsonSerializer.Deserialize<TeamMembers_103082400039>(jsonString);

            Console.WriteLine("Team member list:");
            foreach (var m in data.members)
            {
                Console.WriteLine($"{m.nim} {m.firstname} {m.lastname} ({m.age} {m.gender})");
            }
        }
    }
}
