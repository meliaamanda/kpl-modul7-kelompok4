using System;
using System.IO;
using System.Text.Json;

public class Member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}

public class TeamInfo
{
    public List<Member> members { get; set; }
}

public class TeamMembers
{
    public void ReadJSON()
    {
        string filePath = "jurnal7_2_103082400009.json";

        try
        {
            string jsonString = File.ReadAllText(filePath);
            TeamInfo teamData = JsonSerializer.Deserialize<TeamInfo>(jsonString);

            Console.WriteLine("Team member list:");

            // pengecekan jika data kosong
            if (teamData != null && teamData.members != null)
            {
                foreach (Member member in teamData.members)
                {
                    Console.WriteLine($"{member.nim} {member.firstName} {member.lastName} ({member.age} {member.gender})");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"[Error] File {filePath} tidak ditemukan.");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"[Error] Kesalahan format saat parsing JSON: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Error] : {ex.Message}");
        }
    }
}