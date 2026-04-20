using System;
using System.Text.Json;
using System.IO;

namespace modul7_Kelompok_4
{
    public class Course
    {
        public string firstName { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }
    public class DataMahasiswa103082400009
    {
        public void ReadJSON()
        {
            string filePath = "jurnal7_1_103082400009.json";

            try
            {
                string jsonString = File.ReadAllText(filePath);
                Mahasiswa dataMhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);

                Console.WriteLine("=== DATA MAHASISWA ===");
                Console.WriteLine($"Nama Lengkap  : {dataMhs.firstName} {dataMhs.lastName}");
                Console.WriteLine($"Gender        : {dataMhs.gender}");
                Console.WriteLine($"Umur          : {dataMhs.age} tahun");

                Console.WriteLine("\n=== ALAMAT ===");
                Console.WriteLine($"Jalan         : {dataMhs.address.streetAddress}");
                Console.WriteLine($"Kota          : {dataMhs.address.city}");
                Console.WriteLine($"Provinsi      : {dataMhs.address.state}");

                Console.WriteLine("\n=== MATA KULIAH ===");
                foreach (Course course in dataMhs.courses)
                {
                    Console.WriteLine($"- [{course.code}] {course.name}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"[Error] File {filePath} tidak ditemukan.");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"[Error] Kesalahan saat parsing JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] : {ex.Message}");
            }
        }
    }
}