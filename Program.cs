using modul7_Kelompok_4;

DataMahasiswa103082400009 data = new DataMahasiswa103082400009();
TeamMembers teamMembers = new TeamMembers();
GlossaryItem glosarryItem = new GlossaryItem();
Console.WriteLine("----------Class DataMahasiswa----------");
data.ReadJSON();
Console.WriteLine();

Console.WriteLine("----------Class TeamMembers----------");
teamMembers.ReadJSON();
Console.WriteLine();

Console.WriteLine("----------Class Glossary----------");
glosarryItem.ReadJSON();