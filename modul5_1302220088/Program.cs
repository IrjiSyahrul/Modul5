internal class Program
{
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
        SimpleDataBase<int> dataBase = new SimpleDataBase<int>();
        dataBase.AddNewData(13);
        dataBase.AddNewData(02);
        dataBase.AddNewData(22);
        dataBase.PrintAlldata();
    }
}