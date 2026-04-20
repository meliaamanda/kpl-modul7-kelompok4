using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace modul7_Kelompok_4
{
    internal class DataMahasiswa_103082400039
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string age { get; set; }

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
            string jsonString = File.ReadAllText("jurnal7_1_103082400039.json");

            var data = JsonSerializer.Deserialize<DataMahasiswa_103082400039>(
                jsonString,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            Console.WriteLine("Data Mahasiswa:");
            Console.WriteLine($"Nama: {data.firstName} {data.lastName}");
            Console.WriteLine($"Gender: {data.gender}");
            Console.WriteLine($"Umur: {data.age}");

            Console.WriteLine("\nAlamat:");
            Console.WriteLine($"{data.address.streetAddress}, {data.address.city}, {data.address.state}");

            Console.WriteLine("\nCourses:");
            foreach (var c in data.courses)
            {
                Console.WriteLine($"{c.code} - {c.name}");
            }
        }
    }
}
