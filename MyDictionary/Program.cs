using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> notlar = new MyDictionary<string, int>();

            notlar.Add("Matematik", 100);
            notlar.Add("Bilişim", 85 );
            notlar.Add("Türk Dili ve Edebiyat", 99);
            notlar.Add("Fizik", 85);
            

            notlar.GetAll();
            
        }
    }
}
