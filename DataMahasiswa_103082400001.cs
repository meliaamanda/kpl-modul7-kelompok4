using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

class DataMahasiswa103082400001
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_1_103082400001.json");
        var data = JsonSerializer.Deserialize<DataMahasiswa103082400001>(json);

        Console.WriteLine("Nama: " + data.firstName + " " + data.lastName);
        Console.WriteLine("Gender: " + data.gender);
        Console.WriteLine("Umur: " + data.age);

        Console.WriteLine("Alamat: " +
            data.address.streetAddress + ", " +
            data.address.city + ", " +
            data.address.state);

        Console.WriteLine("Courses:");
        foreach (var c in data.courses)
        {
            Console.WriteLine(c.code + " - " + c.name);
        }
    }
}