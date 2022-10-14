using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            IEnumerable<int> collectionInt = GetCollectionInteger();

            Console.WriteLine("Collection được tạo bằng IEnumerable");
            foreach (var item in collectionInt)
            {
                Console.Write($" {item} ");
            }

            List<string> listString = new List<string>() { "Tom", "Jerry", "Apple" };
            IEnumerator<string> enumerator = listString.GetEnumerator();

            Console.WriteLine("\n Duyệt qua list string bằng IEnumerator");
            while (enumerator.MoveNext())
            { 
                Console.Write($" {enumerator.Current} ");
            }

            //Câu hỏi: các class Dictionary, Stack, Queue có duyệt được với IEnumerator không??

            Console.ReadLine();
        }


        // Phương thức khởi tạo 1 collection bằng interface IEnumerable
        private static IEnumerable<int> GetCollectionInteger()
        {
            int i = 0;

            while (i < 10)
            {
                yield return i++;
            }
        }
            
    }
}
