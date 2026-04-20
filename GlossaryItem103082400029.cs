using System;
using System.IO;
using System.Text.Json;

public class GlossaryItem103082400029
{
    public Glossary glossary { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_3_103082400029.json");

        GlossaryItem103082400029 data = JsonSerializer.Deserialize<GlossaryItem103082400029>(jsonString);

        var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("\nGlossary Entry :");
        Console.WriteLine("\nID : " + entry.ID);
        Console.WriteLine("\nTerm : " + entry.GlossTerm);
        Console.WriteLine("\nDefinition : " + entry.GlossDef.para);
    }
}

public class Glossary
{
    public GlossDiv GlossDiv { get; set; }
}

public class GlossDiv
{
    public GlossList GlossList { get; set; }
}

public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string GlossTerm { get; set; }
    public GlossDef GlossDef { get; set; }
}

public class GlossDef
{
    public string para { get; set; }
}