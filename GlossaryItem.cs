using System;
using System.IO;
using System.Text.Json;
public class GlossDef
{
    public string para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
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

public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }
}

public class Glossary
{
    public string title { get; set; }
    public GlossDiv GlossDiv { get; set; }
}

public class RootNode
{
    public Glossary glossary { get; set; }
}

public class GlossaryItem
{
    public void ReadJSON()
    {
        string filePath = "jurnal7_3_103082400009.json";

        try
        {
            string jsonString = File.ReadAllText(filePath);
            RootNode rootData = JsonSerializer.Deserialize<RootNode>(jsonString);

            if (rootData?.glossary?.GlossDiv?.GlossList?.GlossEntry != null)
            {
                Console.WriteLine("=== PARSING JSON Glossary===");

                Console.WriteLine($"glossary title : \"{rootData.glossary.title}\"");

                if (rootData.glossary.GlossDiv != null)
                {
                    Console.WriteLine($"GlossDiv title : \"{rootData.glossary.GlossDiv.title}\"");

                    if (rootData.glossary.GlossDiv.GlossList?.GlossEntry != null)
                    {
                        GlossEntry entry = rootData.glossary.GlossDiv.GlossList.GlossEntry;

                        Console.WriteLine($"ID             : \"{entry.ID}\"");
                        Console.WriteLine($"SortAs         : \"{entry.SortAs}\"");
                        Console.WriteLine($"GlossTerm      : \"{entry.GlossTerm}\"");
                        Console.WriteLine($"Acronym        : \"{entry.Acronym}\"");
                        Console.WriteLine($"Abbrev         : \"{entry.Abbrev}\"");

                        if (entry.GlossDef != null)
                        {
                            Console.WriteLine($"para           : \"{entry.GlossDef.para}\"");

                            Console.Write("GlossSeeAlso   : [");
                            for (int i = 0; i < entry.GlossDef.GlossSeeAlso.Count; i++)
                            {
                                Console.Write($"\"{entry.GlossDef.GlossSeeAlso[i]}\"");
                                if (i < entry.GlossDef.GlossSeeAlso.Count - 1)
                                {
                                    Console.Write(", ");
                                }
                            }
                            Console.WriteLine("]");
                        }

                        Console.WriteLine($"GlossSee       : \"{entry.GlossSee}\"");
                    }
                }
            }
            else
            {
                Console.WriteLine("[Warning] Data GlossEntry tidak ditemukan atau format JSON tidak sesuai.");
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