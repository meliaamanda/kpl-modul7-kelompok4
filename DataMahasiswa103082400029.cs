using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class DataMahasiswa103082400029
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }

    public static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_1_103082400029.json");

        DataMahasiswa103082400029 data = JsonSerializer.Deserialize<DataMahasiswa103082400029>(jsonString);

        Console.WriteLine("Nama : " + data.firstName + " " + data.lastName);
        Console.WriteLine("Gender : " + data.gender);
        Console.WriteLine("Umur : " + data.age);

        Console.WriteLine("\nAlamat :");
        Console.WriteLine(data.address.streetAddress + ", " + data.address.city + ", " + data.address.state);

        Console.WriteLine("\nCourses :");
        foreach (var course in data.courses)
        {
            Console.WriteLine(course.code + " - " + course.name);
        }
    }
}

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