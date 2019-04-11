using System;
using System.Linq;
using System.Text;

namespace TaskOne
{

    /// задача №1
    /// необходимо просуммировать все найденные числа
    /// исправить потенциальную ошибку
    ///
    /// задачу необходимо реализовать, дописав код, чтобы data.GetDigits() стал работоспособным
   
        
        /* Не удалось сделать так, чтобы data.GetDigits() был работоспособным.
     * Почитаю в интернете про использование методов расширения*/
    class Program
    {

        public static string RandomString(int length )
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            //const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)])
              .Where(x => Char.IsDigit(x)).ToArray());
              
          
        }
       

        static void Main(string[] args)
        {
            string data = RandomString(5);
            int summary = 0;
            
            int[] digits = data.ToString().Select(c => (int)char.GetNumericValue(c)).ToArray();

            summary = digits.Sum();
         
            //    foreach (byte digit in data.GetDigits())
            // {
            //   summary += digit;
            //  }

            Console.WriteLine($"{data} => {summary}");
            Console.ReadKey();
        }
    }
}