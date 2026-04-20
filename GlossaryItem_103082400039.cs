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
            public GlossEntry GlossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string GlossTerm { get; set; }
            public string GlossDefinition { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_3_103082400039.json");
            GlossaryItem_103082400039 data = JsonSerializer.Deserialize<GlossaryItem_103082400039>(jsonString);

            var entry = data.glossary.GlossEntry;

            Console.WriteLine("Glossary:");
            Console.WriteLine($"ID: {entry.ID}");
            Console.WriteLine($"Term: {entry.GlossTerm}");
            Console.WriteLine($"Def: {entry.GlossDefinition}");
        }
    }
}
