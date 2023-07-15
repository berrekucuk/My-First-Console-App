using System.Data;

namespace My_First_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //OOP => Object Oriented Programming => Nesne Yönelimli progamlama
            // Java, PHP, C# , VB, TypeScript
            //Class => Çalışan bir yapıdır. Daha sonra çağrılabilir. Her çalışma class'da çalışılır.


            //string => 
            //int =>
            // boolean => doğru yanlış 
            //date
            //object 
            // Yukarıdaki tipler ilkel tiplerdir => primitive tip

            //string nameLastname = "Berre Küçük"; //Değiken oluşturma
            //string email = "berrekucuk@hotmail.com";
            //isimlendirme Kuralları
            //values = değişken 

            //ram //bellek //memory =>ram parçası

            string name = "Berre";
            int age = 33;
            decimal money = 100.10m;
            double money2 = 100.10;
            DateTime now = DateTime.Now ;
            bool isTrue = true; // 0 => yanlış (False) | 1 => doğru (True)
            object user = new { };

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(money);
            Console.WriteLine( money2);
            Console.WriteLine(now);
            Console.WriteLine(isTrue);

            // ctrl+d kodu aşağıya kopyalar

            //memory tutulma



        }
    }
}