using System;
using System.Collections.Generic;
using System.IO;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            List<int> x = new List<int>();
            List<int> y = new List<int>();
            List<int> z = new List<int>();

            Console.Write("Оберіть тип введеня масивів: \n1 - з файлу \n2 - з клавіатури\nВаріант: ");
            string type = Console.ReadLine();
            int length = 0;
            int length1 = 0;
            if (type == "1")
            {
                char[] charSeparators = new char[] { ' ' };
                string[] res;
                //Витягування данних із файлів
                FileStream file_x = new FileStream("Massive X.txt", FileMode.Open, FileAccess.Read);
                
                StreamReader x_read = new StreamReader(file_x);
                string info_x = x_read.ReadLine();
                res = info_x.Split(charSeparators, StringSplitOptions.None);
                length = res.Length;

                //Запис данних у масив х
                foreach (string i in res)
                    x.Add(Convert.ToInt32(i));
                    


                FileStream file_y = new FileStream("Massive Y.txt", FileMode.Open, FileAccess.Read);

                StreamReader y_read = new StreamReader(file_y);
                string info_y = y_read.ReadLine();
                res = info_y.Split(charSeparators, StringSplitOptions.None);
                length1 = res.Length;

                //Запис данних у масив y
                foreach (string i in res)
                    y.Add(Convert.ToInt32(i));
            }

            else if (type == "2")
            {
                //Заповнення масиву х
                bool flag_x = true;
                string temp;
                
                do
                {
                    Console.WriteLine("Введіть елемент масиву х (щоб закінчити заповнення нажміть Пробіл)");
                    temp = Console.ReadLine();

                    if (temp == " ")
                    {
                        flag_x = false;
                    }
                    else
                    {
                        x.Add(Convert.ToInt32(temp));
                        length++;
                    }

                } while (flag_x);

                // Заповнення масиву у
                bool flag_y = true;
                Console.WriteLine("\n");

                do
                {
                    Console.WriteLine("Введіть елемент масиву y (щоб закінчити заповнення нажміть Пробіл)");
                    temp = Console.ReadLine();

                    if (temp == " ")
                        flag_y = false;
                    else
                    {
                        y.Add(Convert.ToInt32(temp));
                        length1++;
                    }

                } while (flag_y);
            }

            //Вивід масиву х
            Console.WriteLine("Масив x ");
            foreach (int i in x)
                Console.Write(i + ", ");

            Console.WriteLine(" \n ");

            //Вивід масиву y
            Console.WriteLine("Масив y ");
            foreach (int i in y)
                Console.Write(i + ", ");

            Console.WriteLine(" \n ");

            Console.WriteLine("Завдання 1. Збільшити парні елементи масиву х вдвічі" + "\n");

            //Перебираємо елементи масиву, і кожен парний елемент збільшуємо вдвічі
            for (int i = 0; i < length; i += 2)
                x[i] *=2 ;

            Console.WriteLine("Масив х зі збільшеними елементами: ");
            foreach (int i in x)
                Console.Write(i + ", ");


            Console.WriteLine(" \n ");


            Console.WriteLine("Завдання 2. Заповнити масив z, елементи якого є добутком елементів з такими ж індексами із масивів х і у" + "\n");
            //Заповнення масиву z

            int count;
            if (length > length1)
                count = length1;
            else
                count = length;
            
            for (int i = 0; i < count; i += 1)
                z.Add(x[i] * y[i]);
            
            Console.WriteLine("Масив z:");
            foreach (int i in z)
                Console.Write(i + ", ");
        }
    }
}

