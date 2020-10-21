using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            List<double> x = new List<double>();
            List<double> y = new List<double>();
            List<double> z = new List<double>();

            int length;
            int length1;
            
            char[] charSeparators = new char[] { ' ' };
            string[] res;
            //Витягування данних із файлів
            FileStream file_x = new FileStream("Massive X.txt", FileMode.Open, FileAccess.Read);
                
            StreamReader x_read = new StreamReader(file_x);
            string info_x = x_read.ReadLine();
            res = info_x.Split(charSeparators, StringSplitOptions.None);
            length = res.Length;

            //Запис данних у масив х
            double number;
            foreach (string i in res)
                if (double.TryParse(i, out number))
                    x.Add(Convert.ToDouble(i));
                else
                    Console.WriteLine($"У файлі є елемент не типу double - {i}");

            //Витягування данних із файлів
            FileStream file_y = new FileStream("Massive Y.txt", FileMode.Open, FileAccess.Read);

            StreamReader y_read = new StreamReader(file_y);
            string info_y = y_read.ReadLine();
            res = info_y.Split(charSeparators, StringSplitOptions.None);
            length1 = res.Length;

            //Запис данних у масив y
            foreach (string i in res)
                if (double.TryParse(i, out number))
                    y.Add(Convert.ToDouble(number));
                else
                    Console.WriteLine($"У файлі є елемент не типу double - {i}");

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

            for (int i = 0; i < length; i++)
                if (x[i] % 2 == 0)
                    x[i] *=2 ;

            Console.WriteLine("Масив х зі збільшеними елементами: ");
            foreach (int i in x)
                Console.Write(i + ", ");


            Console.WriteLine(" \n ");


            Console.WriteLine("Завдання 2. Заповнити масив z, елементи якого є добутком елементів з такими ж індексами із масивів х і у" + "\n");
            //Заповнення масиву z
            
            List<double> Input_Z(List<double> x, List<double> y)
            {
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
                
                return z;
            }
            Input_Z(x, y);
        }
    }
}

