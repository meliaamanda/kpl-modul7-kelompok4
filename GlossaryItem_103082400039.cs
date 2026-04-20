using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace modul7_Kelompok_4
{
    internal class GlossaryItem_103082400039
    {
        public Glossary glossary { get; set; }

        public class Glossary
        {
            public string title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public string title { get; set; }
            public GlossList GlossList { get; set; }
        }

        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
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
            string jsonString = File.ReadAllText("jurnal7_3_103082400039.json");

            var data = JsonSerializer.Deserialize<GlossaryItem_103082400039>(
                jsonString,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            var entry = data.glossary.GlossDiv.GlossList.GlossEntry;

            Console.WriteLine("Glossary:");
            Console.WriteLine($"ID: {entry.ID}");
            Console.WriteLine($"Term: {entry.GlossTerm}");
            Console.WriteLine($"Def: {entry.GlossDef.para}");
        }
    }
}
