using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class GlossaryItem103082400001
{
    public Glossary glossary { get; set; }

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
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_3_103082400001.json");
        var data = JsonSerializer.Deserialize<GlossaryItem103082400001>(json);

        var g = data.glossary.GlossDiv.GlossList.GlossEntry;

        Console.WriteLine("GlossEntry:");
        Console.WriteLine("ID: " + g.ID);
        Console.WriteLine("Term: " + g.GlossTerm);
        Console.WriteLine("Acronym: " + g.Acronym);
        Console.WriteLine("Abbrev: " + g.Abbrev);
        Console.WriteLine("Definition: " + g.GlossDef.para);

        Console.WriteLine("See Also:");
        foreach (var item in g.GlossDef.GlossSeeAlso)
        {
            Console.WriteLine("- " + item);
        }

        Console.WriteLine("See: " + g.GlossSee);
    }
}