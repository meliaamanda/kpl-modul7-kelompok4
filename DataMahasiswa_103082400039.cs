using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace modul7_Kelompok_4
{
    internal class DataMahasiswa_103082400039
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }
        public string prodi { get; set; }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103082400039.json");
            DataMahasiswa_103082400039 data = JsonSerializer.Deserialize<DataMahasiswa_103082400039>(jsonString);

            Console.WriteLine("Data Mahasiswa:");
            Console.WriteLine($"Nama: {data.nama}");
            Console.WriteLine($"NIM: {data.nim}");
            Console.WriteLine($"Fakultas: {data.fakultas}");
            Console.WriteLine($"Prodi: {data.prodi}");
        }
    }
}
