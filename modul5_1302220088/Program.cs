
﻿internal class Program
{
    class Penjumlahan
    {
        public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic angka = (dynamic)angka1 + (dynamic)angka2 + (dynamic)angka3;
            Console.WriteLine("Hasil pengjumlahan : " + angka);
        }
    }
    class SimpleDataBase<T>
    {
        private List<T> storeData;
        private List<DateTime> inputDates;
      
        public SimpleDataBase()
        {
            this.storeData = new List<T>();
            this.inputDates = new List<DateTime>(); 
        }

        public void AddNewData(T data)
        {
            storeData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAlldata()
        {
            for (int i = 0; i < storeData.Count; i++)
            {
                if (storeData[i] > (dynamic)0 && storeData[i] < (dynamic)10)
                {
                    Console.WriteLine($"Data " + i + " berisi: 0" + storeData[i] + " yang disimpan pada waktu UTC : " + inputDates[i]);
                }
                else
                {
                    Console.WriteLine($"Data " + i + " berisi: " + storeData[i] + " yang disimpan pada waktu UTC : " + inputDates[i]);

                }

            }
        }

    }
    private static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        penjumlahan.JumlahTigaAngka<int>(13, 02, 22);

        SimpleDataBase<int> dataBase = new SimpleDataBase<int>();
        dataBase.AddNewData(13);
        dataBase.AddNewData(02);
        dataBase.AddNewData(22);
        dataBase.PrintAlldata();

    }
}