using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_11
{
   
        class String
        {
            // поля
            int n;
            StringBuilder Line;

            // конструктор, позволяющий создать строку из n символов
            public String(string str)
            {
                Line = new StringBuilder(str);
                n = str.Length;
            }

            // метод для подсчета количества пробелов в строке
            public int probel()
            {
                int count = 0;
                for (int i = 0; i < Line.Length; i++)
                    if (char.IsWhiteSpace(Line[i])) count++;
                return count;
            }

            // метод для замены в строке всех прописных символов на строчные
            public string simvol()
            {
                return Line.ToString().ToLower();
            }

            // метод для удаления из строки всех знаков препинания
            public string delete()
            {
                return Line.ToString().Replace(",", "").Replace("!", "").Replace(".", "").Replace(";", "").Replace(":", "");
            }

            //Свойство возвращающее общее количество элементов в строке 
            public int N
            {
                get { return Line.Length; }
            }

            //Свойство позволяющее установить значение поля, в соответствии с введенным значением строки с клавиатуры, 
            //а также получить значение данного поля
            public int Set_N
            {
                get { return n; } // действия, выполняемые при получении значения свойства

                set { n = value; } //действия, выполняемые при установке значения свойства
        }

           
        }
    internal class Program
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите текст:");
                string str = Console.ReadLine(); 
                String Line = new String(str); //экземпляр класса

                Console.WriteLine("Количество пробелов в тексте: - {0}", Line.probel());

                Console.WriteLine("Заменить в тексте все прописные символы на строчные: \n{0}", Line.simvol());

                Console.WriteLine("Удалить из текста все знаки препинания: \n{0}", Line.delete());

                Console.WriteLine("Общее количество символов в тексте: {0}", Line.N);

               // Console.WriteLine("Значение данного поля: {0}", Line.Set_N);
        }
    }
}







