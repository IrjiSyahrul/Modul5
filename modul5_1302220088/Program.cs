using System.Runtime.InteropServices;

internal class Program
{
    class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic angka = (dynamic)angka1 + (dynamic)angka2 + (dynamic)angka3;
            Console.WriteLine("Hasil pengjumlahan : " + angka);
        }
    }
    private static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        penjumlahan.JumlahTigaAngka<int>(13, 02, 22);
    }
}